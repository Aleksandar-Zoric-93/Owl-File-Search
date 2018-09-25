using DirectorySearch;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OwlFileSearch
{
    public partial class SettingsFrm : Form
    {
        String fileInfoCheck = "";
        String settings2Check = "";
        public String settings3Check = "";
        String settings4Check = "";
        DirectorySearchMain mainFrm = null;
        String exportLocation = "";
        String exportFormat = "";
        String settings5Check = "";
        String version = "";
        String eulaAcceptance = "";

        public SettingsFrm(DirectorySearchMain mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;

            checkFileInformationSetting();
            checkFileDeletionSetting();
            checkAllowMultiSelectforDir();
            checkFileLocationSetting();
            checkFileExportSetting();
            getVersion();
        }

        private void clearWorksBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Works.txt");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the works list?" + Environment.NewLine + "This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(path);
                    settingsStatusTxt.Text = "Works list has been cleared";
                }
                catch (Exception ex) { mainFrm.generateLogFile(ex); };
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do Nothing
            }
        }

        private void clearFavBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Favorites.txt");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the favorites list?" + Environment.NewLine + "This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(path);
                    settingsStatusTxt.Text = "Favorites list has been cleared";
                }
                catch (Exception ex) { mainFrm.generateLogFile(ex); };
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do Nothing
            }
        }

        //Save changes made on settings page
        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting1.txt");

            //File information save
            if (displayFileInfoChk.Checked)
            {
                System.IO.File.WriteAllText(path, "Checked");
                fileInfoCheck = "Checked";
                displayFileInfoChk.Checked = true;

            }
            else if (!displayFileInfoChk.Checked)
            {
                System.IO.File.WriteAllText(path, "Not Checked");
                fileInfoCheck = "Not Checked";
                displayFileInfoChk.Checked = false;
            }
            //End file information save





            //File Explorer Deletion save
            String settings2Path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting2.txt");

            if (fileExplorerDelChk.Checked)
            {
                System.IO.File.WriteAllText(settings2Path, "Checked");
                settings2Check = "Checked";
                fileExplorerDelChk.Checked = true;

            }
            else if (!fileExplorerDelChk.Checked)
            {
                System.IO.File.WriteAllText(settings2Path, "Not Checked");
                settings2Check = "Not Checked";
                fileExplorerDelChk.Checked = false;
            }
            //End File Explorer Deletion save



            //Multi Directory Search save
            String settings3Path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting3.txt");

            if (multipleDirChk.Checked)
            {
                System.IO.File.WriteAllText(settings3Path, "Checked");
                settings3Check = "Checked";
                multipleDirChk.Checked = true;
            }
            else if (!multipleDirChk.Checked)
            {
                System.IO.File.WriteAllText(settings3Path, "Not Checked");
                settings3Check = "Not Checked";
                multipleDirChk.Checked = false;
            }

            //Show/Hide button on main screen depending on checkbox state
            if (settings3Check == "Checked")
            {
                mainFrm.addToDirListBtn.Visible = true;
            }
            if (settings3Check == "Not Checked" || settings3Check == "")
            {
                mainFrm.addToDirListBtn.Visible = false;
            }
            //End Multi Directory Search save


            //Open File Location save
            String settings4Path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting4.txt");

            if (openFileLocChk.Checked)
            {
                System.IO.File.WriteAllText(settings4Path, "Checked");
                settings4Check = "Checked";
                openFileLocChk.Checked = true;

            }
            else if (!openFileLocChk.Checked)
            {
                System.IO.File.WriteAllText(settings4Path, "Not Checked");
                settings4Check = "Not Checked";
                openFileLocChk.Checked = false;
            }
            //End open File Locationn save


            //File Export save
            String settings5Path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting5.txt");

            if (exportChk.Checked)
            {
                System.IO.File.WriteAllText(settings5Path, "Checked");
                settings5Check = "Checked";
                exportChk.Checked = true;

                mainFrm.exportLocation = exportLocation;
                mainFrm.exportFileFormat = exportFormat;

            }
            else if (!exportChk.Checked)
            {
                System.IO.File.WriteAllText(settings5Path, "Not Checked");
                settings5Check = "Not Checked";
                exportChk.Checked = false;
            }

            //Show/Hide button on main screen depending on checkbox state
            if (settings5Check == "Checked")
            {
                mainFrm.exportBtn.Visible = true;
            }
            if (settings5Check == "Not Checked" || settings5Check == "")
            {
                mainFrm.exportBtn.Visible = false;
            }
            //End File Export save

            settingsStatusTxt.Text = "Settings Saved";
            DirectorySearchMain main = new DirectorySearchMain();
        }



        //Check the settings file to see the status of the display/hide file information
        public void checkFileInformationSetting()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting1.txt");

            try
            {
                fileInfoCheck = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            if (fileInfoCheck == "Checked")
            {
                displayFileInfoChk.Checked = true;
            }
            else if (fileInfoCheck == "Not Checked")
            {
                displayFileInfoChk.Checked = false;
            }
        }



        //Check the settings file to see the status of the file exlorer deletion setting
        public void checkFileDeletionSetting()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting2.txt");

            try
            {
                settings2Check = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            if (settings2Check == "Checked")
            {
                fileExplorerDelChk.Checked = true;
            }
            else if (settings2Check == "Not Checked")
            {
                fileExplorerDelChk.Checked = false;
            }
        }

        //Check the settings file to see the status of the file exlorer deletion setting
        public void checkAllowMultiSelectforDir()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting3.txt");

            try
            {
                settings3Check = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            if (settings3Check == "Checked")
            {
                multipleDirChk.Checked = true;
            }
            else if (settings3Check == "Not Checked")
            {
                multipleDirChk.Checked = false;
            }
        }

        //Check the settings file to see the status of the file exlorer deletion setting
        public void checkFileLocationSetting()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting4.txt");

            try
            {
                settings4Check = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            if (settings4Check == "Checked")
            {
                openFileLocChk.Checked = true;
            }
            else if (settings4Check == "Not Checked")
            {
                openFileLocChk.Checked = false;
            }
        }

        //Check the settings file to see the status of the file exlorer deletion setting
        public void checkFileExportSetting()
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting5.txt");

            try
            {
                settings5Check = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            if (settings5Check == "Checked")
            {
                exportChk.Checked = true;
            }
            else if (settings5Check == "Not Checked")
            {
                exportChk.Checked = false;
            }
        }



        //Close Setting Form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainFrm.Show();
        }


        //Set export location
        private void exportLocBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                exportLocation = folderBrowserDialog1.SelectedPath;
                exportLocationLbl.Text = exportLocation;
            }

        }

        //Show/Hide export details if option is enabled/disabled
        private void exportChk_CheckedChanged(object sender, EventArgs e)
        {
            if (exportChk.Checked)
            {
                exportLocBtn.Visible = true;
                exportLbl.Visible = true;
                exportFileFormatSel.Visible = true;
                fileFormatLbl.Visible = true;
                exportLocationLbl.Visible = true;
            }
            else if (!exportChk.Checked)
            {
                exportLocBtn.Visible = false;
                exportLbl.Visible = false;
                exportFileFormatSel.Visible = false;
                fileFormatLbl.Visible = false;
                exportLocationLbl.Visible = false;
            }
        }

        //Set file format for export
        private void exportFileFormatSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportFormat = exportFileFormatSel.Text;
        }

        //Open EULA file
        private void eulaAgreeBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "EULA.rtf");

            System.Diagnostics.Process.Start(path);
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "Log.rtf");

            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                settingsStatusTxt.Text = "Log File Empty";
            }
        }


        //Clear all recent directory searches
        private void clearRecBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Path.Combine(Environment.GetFolderPath(
           Environment.SpecialFolder.MyDocuments), "Owl File Search", "Setting7.txt");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the recents list?" + Environment.NewLine + "This cannot be undone.", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(path);
                    settingsStatusTxt.Text = "Recents list has been cleared";
                }
                catch (Exception ex) { mainFrm.generateLogFile(ex); };
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do Nothing
            }
        }

        //Get current version
        private void getVersion()
        {
          //TODO
        }

        private void acceptEulaAgreement()
        {

        }
    }
}
