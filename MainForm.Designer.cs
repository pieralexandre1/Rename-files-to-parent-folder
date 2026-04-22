namespace Rename_files_to_parent_folder
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            TxtDirectory = new TextBox();
            checkBoxMainFolder = new CheckBox();
            radioButtonChosen = new RadioButton();
            radioButtonRecursive = new RadioButton();
            radioButtonDirect = new RadioButton();
            BtnChoose = new Button();
            BtnRename = new Button();
            buttonUndo = new Button();
            toolTipTopFolder = new ToolTip(components);
            toolTipAppendFolder = new ToolTip(components);
            toolTipDirectParentFolder = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 24);
            label1.TabIndex = 0;
            label1.Text = "Directory of files to change:";
            // 
            // TxtDirectory
            // 
            TxtDirectory.Font = new Font("Microsoft Sans Serif", 14.25F);
            TxtDirectory.Location = new Point(16, 37);
            TxtDirectory.Name = "TxtDirectory";
            TxtDirectory.Size = new Size(495, 29);
            TxtDirectory.TabIndex = 1;
            TxtDirectory.TextChanged += TxtDirectory_TextChanged;
            // 
            // checkBoxMainFolder
            // 
            checkBoxMainFolder.AutoSize = true;
            checkBoxMainFolder.Font = new Font("Microsoft Sans Serif", 14.25F);
            checkBoxMainFolder.Location = new Point(12, 72);
            checkBoxMainFolder.Name = "checkBoxMainFolder";
            checkBoxMainFolder.Size = new Size(453, 28);
            checkBoxMainFolder.TabIndex = 2;
            checkBoxMainFolder.Text = "Start by including parent folder (The chosen folder)";
            checkBoxMainFolder.UseVisualStyleBackColor = true;
            // 
            // radioButtonChosen
            // 
            radioButtonChosen.AutoSize = true;
            radioButtonChosen.Font = new Font("Microsoft Sans Serif", 14.25F);
            radioButtonChosen.Location = new Point(16, 106);
            radioButtonChosen.Name = "radioButtonChosen";
            radioButtonChosen.Size = new Size(114, 28);
            radioButtonChosen.TabIndex = 3;
            radioButtonChosen.Text = "Top folder";
            toolTipTopFolder.SetToolTip(radioButtonChosen, "Will rename all files to the root of the folder chosen.\r\nOr the chosen folder itself if the checkbox is clicked.");
            radioButtonChosen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecursive
            // 
            radioButtonRecursive.AutoSize = true;
            radioButtonRecursive.Checked = true;
            radioButtonRecursive.Font = new Font("Microsoft Sans Serif", 14.25F);
            radioButtonRecursive.Location = new Point(168, 106);
            radioButtonRecursive.Name = "radioButtonRecursive";
            radioButtonRecursive.Size = new Size(148, 28);
            radioButtonRecursive.TabIndex = 4;
            radioButtonRecursive.TabStop = true;
            radioButtonRecursive.Text = "Append folder";
            toolTipAppendFolder.SetToolTip(radioButtonRecursive, "Will rename all files by adding each folder name from the top, \r\nStarting from the root of the chosen folder or the chosen folder.");
            radioButtonRecursive.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirect
            // 
            radioButtonDirect.AutoSize = true;
            radioButtonDirect.Font = new Font("Microsoft Sans Serif", 14.25F);
            radioButtonDirect.Location = new Point(334, 106);
            radioButtonDirect.Name = "radioButtonDirect";
            radioButtonDirect.Size = new Size(186, 28);
            radioButtonDirect.TabIndex = 5;
            radioButtonDirect.Text = "Direct parent folder";
            toolTipDirectParentFolder.SetToolTip(radioButtonDirect, "Will rename all files to the current folder that the files are currently in.");
            radioButtonDirect.UseVisualStyleBackColor = true;
            // 
            // BtnChoose
            // 
            BtnChoose.Font = new Font("Microsoft Sans Serif", 14.25F);
            BtnChoose.Location = new Point(16, 140);
            BtnChoose.Name = "BtnChoose";
            BtnChoose.Size = new Size(231, 32);
            BtnChoose.TabIndex = 6;
            BtnChoose.Text = "Choose folder";
            BtnChoose.UseVisualStyleBackColor = true;
            BtnChoose.Click += BtnChoose_Click;
            // 
            // BtnRename
            // 
            BtnRename.Enabled = false;
            BtnRename.Font = new Font("Microsoft Sans Serif", 14.25F);
            BtnRename.Location = new Point(253, 140);
            BtnRename.Name = "BtnRename";
            BtnRename.Size = new Size(258, 32);
            BtnRename.TabIndex = 7;
            BtnRename.Text = "Rename files";
            BtnRename.UseVisualStyleBackColor = true;
            BtnRename.Click += BtnRename_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.Enabled = false;
            buttonUndo.Font = new Font("Microsoft Sans Serif", 14.25F);
            buttonUndo.Location = new Point(16, 178);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(495, 32);
            buttonUndo.TabIndex = 8;
            buttonUndo.Text = "Undo last rename";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // toolTipTopFolder
            // 
            toolTipTopFolder.AutoPopDelay = 10000;
            toolTipTopFolder.InitialDelay = 410;
            toolTipTopFolder.ReshowDelay = 82;
            // 
            // toolTipAppendFolder
            // 
            toolTipAppendFolder.AutoPopDelay = 10000;
            toolTipAppendFolder.InitialDelay = 410;
            toolTipAppendFolder.ReshowDelay = 82;
            // 
            // toolTipDirectParentFolder
            // 
            toolTipDirectParentFolder.AutoPopDelay = 10000;
            toolTipDirectParentFolder.InitialDelay = 410;
            toolTipDirectParentFolder.ReshowDelay = 82;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 222);
            Controls.Add(buttonUndo);
            Controls.Add(BtnRename);
            Controls.Add(BtnChoose);
            Controls.Add(radioButtonDirect);
            Controls.Add(radioButtonRecursive);
            Controls.Add(radioButtonChosen);
            Controls.Add(checkBoxMainFolder);
            Controls.Add(TxtDirectory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Rename all files to parent folder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtDirectory;
        private CheckBox checkBoxMainFolder;
        private RadioButton radioButtonChosen;
        private RadioButton radioButtonRecursive;
        private RadioButton radioButtonDirect;
        private Button BtnChoose;
        private Button BtnRename;
        private Button buttonUndo;
        private ToolTip toolTipTopFolder;
        private ToolTip toolTipAppendFolder;
        private ToolTip toolTipDirectParentFolder;
    }
}
