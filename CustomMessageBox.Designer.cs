namespace Rename_files_to_parent_folder
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCopy = new Button();
            messageBox = new TextBox();
            btnAccept = new Button();
            btnAlter = new Button();
            SuspendLayout();
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(434, 5);
            btnCopy.Margin = new Padding(4, 3, 4, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(113, 24);
            btnCopy.TabIndex = 0;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(14, 38);
            messageBox.Margin = new Padding(4, 3, 4, 3);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.ReadOnly = true;
            messageBox.ScrollBars = ScrollBars.Vertical;
            messageBox.Size = new Size(532, 296);
            messageBox.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnAccept.Location = new Point(14, 342);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(236, 40);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Close";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnAlter
            // 
            btnAlter.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnAlter.Location = new Point(304, 342);
            btnAlter.Margin = new Padding(4, 3, 4, 3);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(243, 40);
            btnAlter.TabIndex = 3;
            btnAlter.Text = "Detailed";
            btnAlter.UseVisualStyleBackColor = true;
            btnAlter.Click += btnAlter_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 396);
            Controls.Add(btnAlter);
            Controls.Add(btnAccept);
            Controls.Add(messageBox);
            Controls.Add(btnCopy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomMessageBox";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopy;
        private TextBox messageBox;
        private Button btnAccept;
        private Button btnAlter;
    }
}