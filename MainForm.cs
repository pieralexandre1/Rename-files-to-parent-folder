namespace Rename_files_to_parent_folder
{
    public partial class Main : Form
    {
        //Done by PAY, copyright MIT free
        private List<UndoElement> undoElementsList = new List<UndoElement>();
        private int currentDepth = 0;// it start at 0 but it mean 1 will be root
        List<String> listOfErrorDetailed = new List<String>();
        List<String> listOfError = new List<String>();
        bool gotError;
        public Main()
        {
            InitializeComponent();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            this.undoElementsList.Clear();
            buttonUndo.Enabled = false;
            BtnRename.Enabled = false;
            currentDepth = 0;
            this.listOfErrorDetailed.Clear();
            this.listOfError.Clear();
            this.gotError = false;

            if (TxtDirectory.Text != "" && Directory.Exists(TxtDirectory.Text))
            {
                String startedFolder = "";
                if (checkBoxMainFolder.Checked)
                {
                    startedFolder = Path.GetFileName(TxtDirectory.Text);
                }
                int typeOfRename;
                if (radioButtonRecursive.Checked)
                {
                    //Recursive (Append), add all folder name
                    typeOfRename = 2;
                    Rename(TxtDirectory.Text, startedFolder, typeOfRename, "");
                }
                else if (radioButtonDirect.Checked)
                {
                    //Direct parent folder only
                    typeOfRename = 3;
                    Rename(TxtDirectory.Text, startedFolder, typeOfRename, "");
                }
                else
                {
                    //chosen folder, top folder only
                    typeOfRename = 1;
                    Rename(TxtDirectory.Text, startedFolder, typeOfRename, startedFolder);
                }
            }

            if (this.gotError)
            {
                CustomMessageBox cmb = new CustomMessageBox("Files renamed had some error", string.Join(",", this.listOfError), string.Join(",", this.listOfErrorDetailed));
                cmb.ShowDialog();
                this.listOfErrorDetailed.Clear();
                this.listOfError.Clear();
            }
            else
            {
                ConfirmationForm cf = new ConfirmationForm("Files renamed successfully!");
                cf.ShowDialog();
            }

            BtnRename.Enabled = true;
            buttonUndo.Enabled = true;
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string directory = TxtDirectory.Text;
            if (directory != "" && (File.Exists(directory) || Directory.Exists(directory)))
            {
                dialog.SelectedPath = directory;

            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtDirectory.Text = dialog.SelectedPath;
                BtnRename.Enabled = true;
            }
        }

        private void Rename(string path, string folder_name, int typeOfRanaming, string mainFolder)
        {
            currentDepth++;
            if (path != "" && (File.Exists(path) || Directory.Exists(path)))
            {
                string[] folderInDirectory = Directory.GetDirectories(path);
                foreach (string folder in folderInDirectory)
                {
                    if (typeOfRanaming == 2)
                    {
                        Rename(folder, folder_name + " " + Path.GetFileName(folder), typeOfRanaming, "");
                    }
                    else if (typeOfRanaming == 3)
                    {
                        Rename(folder, Path.GetFileName(folder), typeOfRanaming, "");
                    }
                    else
                    {
                        if (currentDepth == 1 && !checkBoxMainFolder.Checked)
                        {
                            mainFolder = Path.GetFileName(folder);
                        }
                        Rename(folder, mainFolder, typeOfRanaming, mainFolder);
                    }
                }
                string[] filesInDirectory = Directory.GetFiles(path);
                foreach (string file in filesInDirectory)
                {
                    //We can skip folder in root chosen if there no change to be done
                    if (!String.IsNullOrEmpty(folder_name))
                    {
                        string new_file_name = folder_name + " " + Path.GetFileName(file);

                        try
                        {
                            // @"\\?\"  -> Needed to bypass the maximum path lenght of 260 characters, its the long path support
                            File.Move(file, @"\\?\" + Path.GetDirectoryName(file) + "\\" + new_file_name);
                        }
                        catch (Exception ex)
                        {
                            this.gotError = true;
                            this.listOfError.Add("Fail to rename : " + file + " to : " + Path.GetDirectoryName(file) + "\\" + new_file_name + "\n");
                            this.listOfErrorDetailed.Add(ex.ToString() + "\n");
                        }


                        this.undoElementsList.Add(new UndoElement(file, Path.GetDirectoryName(file) + "\\" + new_file_name));
                    }
                }
            }
            currentDepth--;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            buttonUndo.Enabled = false;
            List<String> listOfErrorDetailed = new List<String>();
            List<String> listOfError = new List<String>();
            bool gotError = false;
            foreach (UndoElement undoelement in this.undoElementsList)
            {
                try
                {
                    // @"\\?\"  -> Needed to bypass the maximum path lenght of 260 characters, its the long path support
                    File.Move(@"\\?\" + undoelement.getNewFileName(), @"\\?\" + undoelement.getOldFileName());
                }
                catch (Exception ex)
                {
                    gotError = true;
                    listOfError.Add("Fail to undo rename : " + undoelement.getNewFileName() + " to : " + undoelement.getOldFileName() + "\n");
                    listOfErrorDetailed.Add(ex.ToString() + "\n");
                }
            }
            this.undoElementsList.Clear();
            if (gotError)
            {
                CustomMessageBox cmb = new CustomMessageBox("Files renamed undo had some error", string.Join(",", listOfError), string.Join(",", listOfErrorDetailed));
                cmb.ShowDialog();
            }
            else
            {
                ConfirmationForm cf = new ConfirmationForm("Files renamed undo successfully!");
                cf.ShowDialog();
            }
            listOfErrorDetailed.Clear();
            listOfError.Clear();
        }

        private void TxtDirectory_TextChanged(object sender, EventArgs e)
        {
            if (TxtDirectory.Text.Length > 0)
            {
                BtnRename.Enabled = true;
            }
            else
            {
                BtnRename.Enabled = false;
            }
        }
    }
}
