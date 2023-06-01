namespace Minecraft_Automatic_ModDownloader
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.downloadSelected = new System.Windows.Forms.RadioButton();
            this.downloadAll = new System.Windows.Forms.RadioButton();
            this.downloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBox1.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(776, 372);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(760, 416);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(28, 28);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // downloadSelected
            // 
            this.downloadSelected.AutoSize = true;
            this.downloadSelected.ForeColor = System.Drawing.Color.White;
            this.downloadSelected.Location = new System.Drawing.Point(105, 12);
            this.downloadSelected.Name = "downloadSelected";
            this.downloadSelected.Size = new System.Drawing.Size(118, 17);
            this.downloadSelected.TabIndex = 2;
            this.downloadSelected.Text = "Download Selected";
            this.downloadSelected.UseVisualStyleBackColor = true;
            // 
            // downloadAll
            // 
            this.downloadAll.AutoSize = true;
            this.downloadAll.Checked = true;
            this.downloadAll.ForeColor = System.Drawing.Color.White;
            this.downloadAll.Location = new System.Drawing.Point(12, 12);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.Size = new System.Drawing.Size(87, 17);
            this.downloadAll.TabIndex = 3;
            this.downloadAll.TabStop = true;
            this.downloadAll.Text = "Download All";
            this.downloadAll.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.downloadButton.Location = new System.Drawing.Point(12, 416);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(129, 28);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.downloadAll);
            this.Controls.Add(this.downloadSelected);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Main";
            this.Text = "Automatic Mod Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.RadioButton downloadSelected;
        private System.Windows.Forms.RadioButton downloadAll;
        private System.Windows.Forms.Button downloadButton;
    }
}

