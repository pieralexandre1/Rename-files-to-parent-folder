namespace Rename_files_to_parent_folder
{
    partial class ConfirmationForm
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
            imageInformation = new PictureBox();
            labelText = new Label();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)imageInformation).BeginInit();
            SuspendLayout();
            // 
            // imageInformation
            // 
            imageInformation.Location = new Point(13, 13);
            imageInformation.Name = "imageInformation";
            imageInformation.Size = new Size(49, 67);
            imageInformation.SizeMode = PictureBoxSizeMode.CenterImage;
            imageInformation.TabIndex = 0;
            imageInformation.TabStop = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(68, 35);
            labelText.Name = "labelText";
            labelText.Size = new Size(291, 24);
            labelText.TabIndex = 1;
            labelText.Text = "Files renamed undo successfully!";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.Cancel;
            btnOk.Location = new Point(267, 73);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(91, 30);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ConfirmationForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOk;
            ClientSize = new Size(370, 115);
            Controls.Add(btnOk);
            Controls.Add(labelText);
            Controls.Add(imageInformation);
            Font = new Font("Microsoft Sans Serif", 14.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "ConfirmationForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Renaming";
            ((System.ComponentModel.ISupportInitialize)imageInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageInformation;
        private Label labelText;
        private Button btnOk;
    }
}