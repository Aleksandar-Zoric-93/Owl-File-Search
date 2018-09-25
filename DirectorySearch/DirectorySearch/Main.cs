using OwlFileSearch;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DirectorySearch
{
    public partial class DirectorySearchMain : Form
    {
        //Variable Declaration
        List<string> status = new List<string>();
        string folderPath = "";
        string selectedPath = "";
        string path;
        String[] resultList = new String[] { };
        String[] fileList = new String[] { };
        String fileInfoDisplayChk = "";
        String fileExplorerDelChk = "";
        String allowMultiDirSearchChk = "";
        String openFileLocChk = "";
        String exportFileChk = "";
        String selItem;
        public String exportLocation = "";
        public String exportFileFormat = "";
        SettingsFrm settingFrm;

        //Constructor
        public DirectorySearchMain()
        {
            InitializeComponent();
            getSetting1();
            getSetting2();
            getSetting3();
            getSetting4();
            getSetting5();
            dirSearcChkBox.Checked = true;

            // Create a event controls.          
            fileSearchTxt.KeyPress += new KeyPressEventHandler(keyPressed);
            resultListDisplay.MouseDoubleClick += new MouseEventHandler(doubleClickEvent);

            //Create application directory in users Documents folder
            try
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Owl File Search"));
            }
            catch (Exception ex)
            {
                statusTxt.Text = "Error occured retrieving application settings";
                generateLogFile(ex);
            }

            checkForEULA();
        }



        //If the ENTER key is pressed
        private void keyPressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //If Recents is selected
                if (recentFileSrc.Checked)
                {
                    folderPath = selItem;

                    beginSearch();
                }
                else
                {
                    //Start file search
                    beginSearch();
                }
            }
        }

        //If LEFT MOUSE BUTTON is double-clicked
        private void doubleClickEvent(object o, MouseEventArgs e)
        {
            //If Recents is selected
            if (recentFileSrc.Checked)
            {
                folderPath = selItem;

                beginSearch();
            }
            else
            {
                try
                {
                    openFile();
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
        }


        //If the SEARCH button is clicked
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Start file search
            beginSearch();
        }






        //File Search
        public void beginSearch()
        {
            //Reset all statuses
            overallStatusTxt.Text = "";
            statusTxt.Text = "";
            matchesFoundDisplayTxt.Text = "";
            dirPathTxt.Text = "";
            fileInfoLbl.Text = "";
            fileNameLbl.Text = "";

            getSetting1();
            getSetting2();

            if (!favChkBox.Checked || !workOnChkBox.Checked)
            {
                deleteBtn.Visible = false;
            }

            if (folderPath != String.Empty && !dirSearcChkBox.Checked && !favChkBox.Checked && !workOnChkBox.Checked && !recentFileSrc.Checked)
            {
                resultListDisplay.Items.Clear();
                statusTxt.Text = "Please check the 'Directory Search' option when searching a directory";
            }

            //Display search parameters
            if (folderPath == String.Empty && !favChkBox.Checked && !workOnChkBox.Checked)
            {
                statusTxt.Text = "Please select a directory to search";
                resultListDisplay.Items.Clear();
            }

            else if (dirSearcChkBox.Checked || recentFileSrc.Checked)
            {
                if (recentFileSrc.Checked)
                {
                    recentFileSrc.Checked = false;
                    dirSearcChkBox.Checked = true;
                }

                //If it is a directory search
                workOnChkBox.Checked = false;
                favChkBox.Checked = false;

                resultListDisplay.Items.Clear();
                dirPathTxt.Text = String.Join(Environment.NewLine, folderPath + " - Directory Search");


                //If it is a file search
                resultListDisplay.Items.Clear();
                String fileName = fileSearchTxt.Text;
                try
                {
                    resultList = Directory.GetFiles(folderPath, "*" + fileName + "*", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    //Clear list of previous files if this exception occurs
                    resultListDisplay.Items.Clear();
                    statusTxt.Text = "You do not have permissions to access this directory";
                    generateLogFile(ex);
                    return;
                }

                foreach (var item in resultList)
                {
                    //Begin & end update to increase performance when dislaying items to listbox
                    resultListDisplay.BeginUpdate();
                    fileName = String.Empty;
                    status.Add(item);

                    resultListDisplay.Items.Add(item);
                    resultListDisplay.EndUpdate();
                }
                //Display how many records were returned i.e. matches found
                int matchesFound = resultListDisplay.Items.Count;
                matchesFoundDisplayTxt.Text = String.Join(Environment.NewLine, "Matches Found: " + matchesFound);
            }
        }




        //Open selected file
        public void openFile()
        {
            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);

            //Check whether the Open File Location is enabled or disabled
            getSetting4();

            //Checks to see if a file is selected
            if (selectedPath == "")
            {
                statusTxt.Text = "No item selected";
            }

            //Open file in explorer          
            if (File.Exists(selectedPath))
            {
                //Open File
                if (openFileLocChk == "Not Checked" || openFileLocChk == "")
                {
                    System.Diagnostics.Process.Start(selectedPath);
                }
                //Open file location
                else if (openFileLocChk == "Checked")
                {
                    Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + selectedPath));
                }
            }
            else if (!File.Exists(selectedPath))
            {
                statusTxt.Text = "This file has been deleted, moved or renamed.";
            }
        }





        //Directory search button event
        private void dirSearchBtn_Click(object sender, EventArgs e)
        {
            //Switch to directory search
            if (!dirSearcChkBox.Checked)
            {
                dirSearcChkBox.Checked = true;
            }

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            dirPathTxt.Text = String.Join(Environment.NewLine, folderPath);

            //Hide Add to Search button
            if (allowMultiDirSearchChk == "Checked" && !dirSearcChkBox.Checked)
            {
                addToDirListBtn.Visible = false;
            }

            //Clear status labels after a new directory is selected
            overallStatusTxt.Text = "";
            statusTxt.Text = "";
            matchesFoundDisplayTxt.Text = "";
            fileInfoLbl.Text = "";
            fileNameLbl.Text = "";

            saveMostRecentDirectories();
        }




        //Open file event via button on screen
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openFile();
        }




        //Add a selected file to favorites for quick access later
        public void addToFavorites()
        {
            //Set Dir and binary file name
            path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Favorites.txt");

            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
            File.AppendAllText(path, selectedPath + Environment.NewLine);

            overallStatusTxt.Text = "Added to favorites";
        }


        //Add a selected file to works for quick access later
        public void addToWorks()
        {
            //Set Dir and binary file name
            path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Works.txt");

            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
            File.AppendAllText(path, selectedPath + Environment.NewLine);
            overallStatusTxt.Text = "Added to works";
        }


        //Add to Favorites button event
        private void addToFavBtn_Click(object sender, EventArgs e)
        {
            addToFavorites();
        }


        //Add to works button event
        private void button1_Click(object sender, EventArgs e)
        {
            addToWorks();
        }




        //On item selection change event
        private void resultListDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo oFileInfo;
            String fileName;

            if (recentFileSrc.Checked)
            {
                selItem = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
                fileName = Path.GetFileName(selItem);
                fileNameLbl.Text = fileName.ToString();
            }
            else
            {
                //Display delete button
                if (resultListDisplay.SelectedIndex != -1 && favChkBox.Checked || workOnChkBox.Checked)
                {
                    deleteBtn.Visible = true;
                }

                try
                {
                    //Always display file name
                    selItem = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
                    oFileInfo = new FileInfo(selItem);
                    fileName = Path.GetFileName(selItem);
                    fileNameLbl.Text = fileName.ToString();
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }

                //Check if settings is shown to hide or display file information
                if (fileInfoDisplayChk == "Not Checked" || fileInfoDisplayChk == "")
                {
                    //Display file information 
                    selItem = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
                    long fileSize;
                    DateTime dtCreationTime;
                    DateTime dtModifiedTime;
                    try
                    {
                        oFileInfo = new FileInfo(selItem);
                        dtCreationTime = oFileInfo.CreationTime;
                        dtModifiedTime = oFileInfo.LastWriteTime;
                        fileSize = oFileInfo.Length / 1000;

                        if (fileSize == 0)
                        {
                            fileSize = oFileInfo.Length;
                            fileInfoLbl.Text = "File Size: " + fileSize.ToString() + " Bytes" + Environment.NewLine + "Date Created: " + dtCreationTime.ToString() + Environment.NewLine + "Date Modified: " + dtModifiedTime.ToString();
                        }
                        else if (fileSize > 1000)
                        {
                            fileSize = fileSize / 1000;
                            fileInfoLbl.Text = "File Size: " + fileSize.ToString() + " Mb" + Environment.NewLine + "Date Created: " + dtCreationTime.ToString() + Environment.NewLine + "Date Modified: " + dtModifiedTime.ToString();
                        }
                        else if (fileSize > 0)
                        {
                            fileInfoLbl.Text = "File Size: " + fileSize.ToString() + " Kb" + Environment.NewLine + "Date Created: " + dtCreationTime.ToString() + Environment.NewLine + "Date Modified: " + dtModifiedTime.ToString();
                        }
                    }
                    catch (Exception ex) { generateLogFile(ex); };
                }
                else if (fileInfoDisplayChk == "Checked")
                {
                    //Do nothing
                }
            }
        }





        //Delete feature
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            getSetting2();
            //Get the selected item
            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
            string LinesToDelete = selectedPath;

            //Get path to favorites.txt file
            String path2 = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Favorites.txt");

            //Get path to works.txt file
            String path3 = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Works.txt");

            //Checks to see if a file is selected
            if (selectedPath == "")
            {
                statusTxt.Text = "No item selected";
            }

            //Whether the file exists or not, allow user to delete    
            if (File.Exists(selectedPath) || !File.Exists(selectedPath))
            {

                //Remove file from list
                resultListDisplay.Items.Remove(selectedPath);

                //Remove file from array
                var list = new List<string>(resultList);
                list.Remove(selectedPath);
                resultList = list.ToArray();

                //Check whether the file is being deleted from favorites or works list
                if (favChkBox.Checked)
                {
                    if (fileExplorerDelChk == "Checked")
                    {
                        File.Delete(selectedPath);
                    }
                    var Lines = File.ReadAllLines(path2);
                    var newLines = Lines.Where(line => !line.Contains(LinesToDelete));
                    File.WriteAllLines(path2, newLines);
                    overallStatusTxt.Text = "File deleted from favorites";
                }
                else if (workOnChkBox.Checked)
                {
                    if (fileExplorerDelChk == "Checked")
                    {
                        File.Delete(selectedPath);
                    }
                    var Lines = File.ReadAllLines(path3);
                    var newLines = Lines.Where(line => !line.Contains(LinesToDelete));
                    File.WriteAllLines(path3, newLines);
                    overallStatusTxt.Text = "File deleted from works";
                }

            }
        }




        //Information button event.
        private void infoBtn_Click(object sender, EventArgs e)
        {
            SettingsFrm settingsFrm = new SettingsFrm(this);
            settingsFrm.Show();
            this.Hide();
        }





        //Check the settings file to see the status of the display/hide file information
        public void getSetting1()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting1.txt");

            if (File.Exists(path))
            {
                try
                {
                    fileInfoDisplayChk = System.IO.File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }

        }




        //Check the settings file to see the status of the delete file from explorer setting
        public void getSetting2()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting2.txt");

            if (File.Exists(path))
            {
                try
                {
                    fileExplorerDelChk = System.IO.File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
        }





        //Check the settings file to see the status of the delete file from explorer setting
        public void getSetting3()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting3.txt");

            if (File.Exists(path))
            {
                try
                {
                    allowMultiDirSearchChk = System.IO.File.ReadAllText(path);
                    if (allowMultiDirSearchChk == "Checked")
                    {
                        addToDirListBtn.Visible = true;
                    }
                    if (allowMultiDirSearchChk == "Not Checked")
                    {
                        addToDirListBtn.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
        }





        //Check the settings file to see the status of the delete file from explorer setting
        public void getSetting4()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting4.txt");

            if (File.Exists(path))
            {
                try
                {
                    openFileLocChk = System.IO.File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
        }






        //Check the settings file to see the status of the export file setting
        public void getSetting5()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting5.txt");

            if (File.Exists(path))
            {
                try
                {
                    exportFileChk = System.IO.File.ReadAllText(path);

                    if (exportFileChk == "Checked")
                    {
                        exportBtn.Visible = true;
                    }
                    if (exportFileChk == "Not Checked")
                    {
                        exportBtn.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
        }





        //Expand search to multiple directories
        private void addToDirListBtn_Click(object sender, EventArgs e)
        {
            //Display search parameters
            if (folderPath == String.Empty && !favChkBox.Checked && !workOnChkBox.Checked)
            {
                statusTxt.Text = "Please select a directory to search";
                resultListDisplay.Items.Clear();
            }
            else if (dirSearcChkBox.Checked)
            {
                String fileName = fileSearchTxt.Text;
                try
                {
                    fileList = Directory.GetFiles(folderPath, "*" + fileName + "*", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    statusTxt.Text = "Could not retrieve files";
                    generateLogFile(ex);
                }

                //Add array items to List
                List<string> strList = new List<string>(fileList);
                resultListDisplay.Items.AddRange(strList.ToArray());

                //Display total matches found across all selected directories
                int matchesFound = resultListDisplay.Items.Count;
                overallStatusTxt.Text = "Expanded search to " + folderPath;

                matchesFoundDisplayTxt.Text = String.Join(Environment.NewLine, "Matches Found: " + matchesFound);
            }
        }





        //Check what main option is checked/Not checked and enabled/disable 'add to search' button
        private void workOnChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Clear status labels after a new main selection is selected
            overallStatusTxt.Text = "";
            statusTxt.Text = "";
            matchesFoundDisplayTxt.Text = "";
            fileInfoLbl.Text = "";
            fileNameLbl.Text = "";
            dirPathTxt.Text = "";
            resultListDisplay.Items.Clear();

            addToDirListBtn.Visible = false;
            searchBtn.Visible = false;
            addToWorksBtn.Visible = false;
            addToFavBtn.Visible = false;
            deleteBtn.Visible = false;
            selectDirBtn.Visible = false;

            //Display Work Ons
            if (workOnChkBox.Checked)
            {

                //Hide Add to Search button
                if (allowMultiDirSearchChk == "Checked")
                {
                    addToDirListBtn.Visible = false;
                }

                path = System.IO.Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments), "Owl File Search", "Works.txt");
                StreamReader sr;

                folderPath = "";
                fileSearchTxt.Text = "";
                dirSearcChkBox.Checked = false;
                favChkBox.Checked = false;
                resultListDisplay.Items.Clear();

                matchesFoundDisplayTxt.Text = "Currently Working On";

                try
                {
                    sr = new StreamReader(path);
                    string line;
                    // Read and display lines from the file until the end of  
                    // the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        resultListDisplay.Items.Add(line);
                    }

                    sr.Close();
                }
                catch (Exception ex)
                {
                    statusTxt.Text = "No items contained in Works";
                    generateLogFile(ex);
                }
            }

        }




        private void favChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Clear status labels after a new main selection is selected
            overallStatusTxt.Text = "";
            statusTxt.Text = "";
            matchesFoundDisplayTxt.Text = "";
            fileInfoLbl.Text = "";
            fileNameLbl.Text = "";
            dirPathTxt.Text = "";
            resultListDisplay.Items.Clear();

            addToDirListBtn.Visible = false;
            searchBtn.Visible = false;
            addToWorksBtn.Visible = false;
            addToFavBtn.Visible = false;
            deleteBtn.Visible = false;
            selectDirBtn.Visible = false;

            //Display Favorites
            if (favChkBox.Checked && !dirSearcChkBox.Checked)
            {
                //Hide Add to Search button              
                addToDirListBtn.Visible = false;


                path = System.IO.Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments), "Owl File Search", "Favorites.txt");

                StreamReader sr;

                folderPath = "";
                fileSearchTxt.Text = "";
                dirSearcChkBox.Checked = false;
                workOnChkBox.Checked = false;
                resultListDisplay.Items.Clear();

                matchesFoundDisplayTxt.Text = "Favorites Only";
                try
                {
                    sr = new StreamReader(path);
                    string line;
                    // Read and display lines from the file until the end of  
                    // the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        resultListDisplay.Items.Add(line);
                    }

                    sr.Close();
                }
                catch (Exception ex)
                {
                    statusTxt.Text = "No items contained in Favorites";
                    generateLogFile(ex);
                }

            }
        }

        private void dirSearcChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Clear status labels after a new main selection is selected
            overallStatusTxt.Text = "";
            statusTxt.Text = "";
            matchesFoundDisplayTxt.Text = "";
            fileInfoLbl.Text = "";
            fileNameLbl.Text = "";
            dirPathTxt.Text = "";
            resultListDisplay.Items.Clear();
            settingFrm = new SettingsFrm(this);

            searchBtn.Visible = true;
            addToWorksBtn.Visible = true;
            addToFavBtn.Visible = true;
            deleteBtn.Visible = false;
            selectDirBtn.Visible = false;

            if (settingFrm.settings3Check == "Checked")
            {
                addToDirListBtn.Visible = true;
            }
        }




        //Export button event - export displayed file list to file
        private void exportBtn_Click(object sender, EventArgs e)
        {
            statusTxt.Text = "";

            //Select a random number to differentiate files
            Random rnd = new Random();
            int exportNo = rnd.Next(1, 999999);
            String exportPath = exportLocation + "\\OwlFileSearch_Export" + exportNo + exportFileFormat;

            //Write file list to file
            try
            {
                StreamWriter myOutputStream = new StreamWriter(exportPath);

                foreach (var item in resultListDisplay.Items)
                {
                    myOutputStream.WriteLine(item.ToString());
                }

                overallStatusTxt.Text = "Exported to " + exportPath;
                myOutputStream.Close();
            }
            catch (Exception ex)
            {
                statusTxt.Text = "Please check export settings";
                generateLogFile(ex);
            }
        }
        //End of Export button event - export displayed file list to file


        //Save recent directory searches
        public void saveMostRecentDirectories()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting7.txt");

            try
            {
                if (File.Exists(path))
                {
                    if (new FileInfo(path).Length == 0)
                    {
                        //If file is empty, write first line
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine(folderPath);
                        }
                    }
                    else
                    {
                        //If file not empty, append to current lines of text
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(folderPath);
                        }
                    }
                }
                else
                {
                    //Create file if it does not exist
                    var myFile = File.Create(path);
                    myFile.Close();
                }

            }
            catch (Exception ex)
            {
                generateLogFile(ex);
            }
        }

        //Show recent directory searches
        private void recentFileSrc_CheckedChanged(object sender, EventArgs e)
        {
            selectDirBtn.Visible = true;
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting7.txt");

            //If file exists, read and add to display
            if (File.Exists(path))
            {
                try
                {
                    //Get all directory searches
                    string[] recentDir = System.IO.File.ReadAllLines(path);

                    //Get last 20 directory searches
                    string[] recent20Dir = recentDir.Reverse().Take(20).Reverse().ToArray();
                    resultListDisplay.Items.AddRange(recent20Dir);

                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }

            matchesFoundDisplayTxt.Text = "Recent Directory Searches";
        }

        private void selectDirBtn_Click(object sender, EventArgs e)
        {
            folderPath = selItem;

            beginSearch();
        }





        //Create EULA Agreement
        private void checkForEULA()
        {
            String EULA = "End-User License Agreement (EULA) of Owl File Search.  This End-User License Agreement (EULA) is a legal agreement between you and Aleksandar Zoric.  This EULA agreement governs your acquisition and use of our Owl File Search software (Software) directly from Aleksandar Zoric or indirectly through a Aleksandar Zoric authorized reseller or distributor (a Reseller). Please read this EULA agreement carefully before completing the installation process and using the Owl File Search software. It provides a license to use the Owl File Search software and contains warranty information and liability disclaimers. If you register for a free trial of the Owl File Search software, this EULA agreement will also govern that trial. By clicking accept or installing and/or using the Owl File Search software, you are confirming your acceptance of the Software and agreeing to become bound by the terms of this EULA agreement. If you are entering into this EULA agreement on behalf of a company or other legal entity, you represent that you have the authority to bind such entity and its affiliates to these terms and conditions. If you do not have such authority or if you do not agree with the terms and conditions of this EULA agreement, do not install or use the Software, and you must not accept this EULA agreement. This EULA agreement shall apply only to the Software supplied by Aleksandar Zoric herewith regardless of whether other software is referred to or described herein. The terms also apply to any Aleksandar Zoric updates, supplements, Internet-based services, and support services for the Software, unless other terms accompany those items on delivery. If so, those terms apply. License Grant Aleksandar Zoric hereby grants you a personal, non-transferable, non-exclusive licence to use the Owl File Search software on your devices in accordance with the terms of this EULA agreement. You are permitted to load the Owl File Search software (for example a PC, laptop, mobile or tablet) under your control. You are responsible for ensuring your device meets the minimum requirements of the Owl File Search software. You are not permitted to: - Edit, alter, modify, adapt, translate or otherwise change the whole or any part of the Software nor permit the whole or any part of the Software to be combined with or become incorporated in any other software, nor decompile, disassemble or reverse engineer the Software or attempt to do any such things - Reproduce, copy, distribute, resell or otherwise use the Software for any commercial purpose - Allow any third party to use the Software on behalf of or for the benefit of any third party - Use the Software in any way which breaches any applicable local, national or international law - use the Software for any purpose that Aleksandar Zoric considers is a breach of this EULA agreement Intellectual Property and Ownership Aleksandar Zoric shall at all times retain ownership of the Software as originally downloaded by you and all subsequent downloads of the Software by you. The Software (and the copyright, and other intellectual property rights of whatever nature in the Software, including any modifications made thereto) are and shall remain the property of Aleksandar Zoric. Aleksandar Zoric reserves the right to grant licences to use the Software to third parties. Termination This EULA agreement is effective from the date you first use the Software and shall continue until terminated. You may terminate it at any time upon written notice to Aleksandar Zoric. This EULA was created by eulatemplate.com for Owl File Search It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon such termination, the licenses granted by this EULA agreement will immediately terminate and you agree to stop all access and use of the Software. The provisions that by their nature continue and survive will survive any termination of this EULA agreement. Governing Law This EULA agreement, and any dispute arising out of or in connection with this EULA agreement, shall be governed by and construed in accordance with the laws of Ireland.";

            String EULApath = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "EULA.rtf");

            if (!File.Exists(EULApath))
            {
                try
                {
                    System.IO.File.WriteAllText(EULApath, EULA);
                    SetFileReadAccess(EULApath, true);

                }
                catch (Exception ex)
                {
                    generateLogFile(ex);
                }
            }
            else
            {
                //Do nothing
            }
        }

        //Set File Access to any file passed
        public static void SetFileReadAccess(string FileName, bool SetReadOnly)
        {
            try
            {
                FileInfo fInfo = new FileInfo(FileName);
                fInfo.IsReadOnly = SetReadOnly;

            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }


        //Generate log file when an error occurs
        public void generateLogFile(Exception ex)
        {
            String logPath = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Log.rtf");

            try
            {
                SetFileReadAccess(logPath, false);
                using (StreamWriter writer = new StreamWriter(logPath, true))
                {
                    writer.WriteLine("Summary: " + ex.Message + Environment.NewLine + Environment.NewLine + "Trace: " + ex.StackTrace +
                       "" + Environment.NewLine + Environment.NewLine + "Date: " + DateTime.Now.ToString());
                    writer.WriteLine(Environment.NewLine + "--------------------------------------------------------------" + Environment.NewLine);
                }
                SetFileReadAccess(logPath, true);
            }
            catch (Exception exc)
            {
                generateLogFile(exc);
            }
        }   
    }
}

