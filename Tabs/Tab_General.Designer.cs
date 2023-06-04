namespace Minecraft_Automatic_ModDownloader.Tabs
{
    partial class Tab_General
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jsonDownloadPathTextBox = new System.Windows.Forms.TextBox();
            this.deleteModsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalLabel.ForeColor = System.Drawing.Color.White;
            this.generalLabel.Location = new System.Drawing.Point(3, 9);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(99, 29);
            this.generalLabel.TabIndex = 9;
            this.generalLabel.Text = "General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Json Download Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jsonDownloadPathTextBox
            // 
            this.jsonDownloadPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonDownloadPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.jsonDownloadPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jsonDownloadPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonDownloadPathTextBox.ForeColor = System.Drawing.Color.White;
            this.jsonDownloadPathTextBox.Location = new System.Drawing.Point(295, 47);
            this.jsonDownloadPathTextBox.MaxLength = 500;
            this.jsonDownloadPathTextBox.Name = "jsonDownloadPathTextBox";
            this.jsonDownloadPathTextBox.Size = new System.Drawing.Size(280, 26);
            this.jsonDownloadPathTextBox.TabIndex = 11;
            this.jsonDownloadPathTextBox.WordWrap = false;
            this.jsonDownloadPathTextBox.TextChanged += new System.EventHandler(this.jsonDownloadPathTextBox_TextChanged);
            this.jsonDownloadPathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jsonDownloadPathTextBox_KeyUp);
            // 
            // deleteModsCheckBox
            // 
            this.deleteModsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteModsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteModsCheckBox.ForeColor = System.Drawing.Color.White;
            this.deleteModsCheckBox.Location = new System.Drawing.Point(3, 79);
            this.deleteModsCheckBox.Name = "deleteModsCheckBox";
            this.deleteModsCheckBox.Size = new System.Drawing.Size(487, 24);
            this.deleteModsCheckBox.TabIndex = 12;
            this.deleteModsCheckBox.Text = "Delete mods in mods folder";
            this.deleteModsCheckBox.UseVisualStyleBackColor = true;
            this.deleteModsCheckBox.CheckedChanged += new System.EventHandler(this.deleteModsCheckBox_CheckedChanged);
            // 
            // Tab_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.deleteModsCheckBox);
            this.Controls.Add(this.jsonDownloadPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generalLabel);
            this.Name = "Tab_General";
            this.Size = new System.Drawing.Size(578, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label generalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jsonDownloadPathTextBox;
        private System.Windows.Forms.CheckBox deleteModsCheckBox;
    }
}
