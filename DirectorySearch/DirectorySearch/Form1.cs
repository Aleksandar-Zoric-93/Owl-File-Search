using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Constructor
        public DirectorySearchMain()
        {
            InitializeComponent();
        }


        //File search button event
        private void searchBtn_Click(object sender, EventArgs e)
        {
            String[] resultList = new String[] { };
            path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Zor Search", "Favorites.txt");

            //Display Favorites
            if (favChkBox.Checked)
            {
                folderPath = "";
                fileSearchTxt.Text = "";
                dirSearcChkBox.Checked = false;
                resultListDisplay.Items.Clear();

                dirPathTxt.Text = path;
                matchesFoundDisplayTxt.Text = "Favorites Only";
                StreamReader sr = new StreamReader(path);
                string line;
                // Read and display lines from the file until the end of  
                // the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    resultListDisplay.Items.Add(line);
                }
            }

            //Display search parameters
            if (folderPath == String.Empty)
            {
                statusTxt.Text = "Please select a directory to search";
            }
            else
            {
                if (dirSearcChkBox.Checked)
                {
                    fileSearchTxt.Text = "";
                    dirPathTxt.Text = String.Join(Environment.NewLine, folderPath + " - Directory Search");
                }
                resultListDisplay.Items.Clear();
                String fileName = fileSearchTxt.Text;
                try
                {
                    resultList = Directory.GetFiles(folderPath, "*" + fileName + "*", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    statusTxt.Text = "You do not have permissions to access this directory";
                }

                foreach (var item in resultList)
                {
                    fileName = String.Empty;
                    status.Add(item);
                    resultListDisplay.Items.Add(item);
                }
                matchesFoundDisplayTxt.Text = String.Join(Environment.NewLine, "Matches Found: " + resultList.Length);
            }

        }


        //Directory search button event
        private void dirSearchBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            dirPathTxt.Text = String.Join(Environment.NewLine, folderPath);
        }


        //Open file event
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (selectedPath == String.Empty && !dirSearcChkBox.Checked && !favChkBox.Checked)
            {
                statusTxt.Text = "No item selected";
            }

            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
            if (File.Exists(selectedPath))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + selectedPath));
            }
        }


        //Add a selected file to favorites for quick access later
        public void addToFavorites()
        {
            //Set Dir and binary file name
            path = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Zor Search", "Favorites.txt");

            MessageBox.Show(path);

            selectedPath = resultListDisplay.GetItemText(resultListDisplay.SelectedItem);
            File.AppendAllText(path, selectedPath + Environment.NewLine);
        }

        //Add to Favorites button event
        private void addToFavBtn_Click(object sender, EventArgs e)
        {
            addToFavorites();
        }
    }
}

