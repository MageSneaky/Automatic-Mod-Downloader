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
            this.SettingsButton = new System.Windows.Forms.Button();
            this.downloadSelected = new System.Windows.Forms.RadioButton();
            this.downloadAll = new System.Windows.Forms.RadioButton();
            this.modsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.downloadButton = new Minecraft_Automatic_ModDownloader.CustomButton();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(756, 411);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(32, 32);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // downloadSelected
            // 
            this.downloadSelected.AutoSize = true;
            this.downloadSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadSelected.ForeColor = System.Drawing.Color.White;
            this.downloadSelected.Location = new System.Drawing.Point(130, 12);
            this.downloadSelected.Name = "downloadSelected";
            this.downloadSelected.Size = new System.Drawing.Size(143, 20);
            this.downloadSelected.TabIndex = 2;
            this.downloadSelected.Text = "Download Selected";
            this.downloadSelected.UseVisualStyleBackColor = true;
            // 
            // downloadAll
            // 
            this.downloadAll.AutoSize = true;
            this.downloadAll.Checked = true;
            this.downloadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadAll.ForeColor = System.Drawing.Color.White;
            this.downloadAll.Location = new System.Drawing.Point(12, 12);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.Size = new System.Drawing.Size(104, 20);
            this.downloadAll.TabIndex = 3;
            this.downloadAll.TabStop = true;
            this.downloadAll.Text = "Download All";
            this.downloadAll.UseVisualStyleBackColor = true;
            // 
            // modsContainer
            // 
            this.modsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsContainer.AutoScroll = true;
            this.modsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.modsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.modsContainer.ForeColor = System.Drawing.Color.White;
            this.modsContainer.Location = new System.Drawing.Point(12, 39);
            this.modsContainer.Name = "modsContainer";
            this.modsContainer.Padding = new System.Windows.Forms.Padding(10);
            this.modsContainer.Size = new System.Drawing.Size(776, 366);
            this.modsContainer.TabIndex = 0;
            this.modsContainer.WrapContents = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.BackgroundImage")));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(718, 411);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(32, 32);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.downloadButton.BackColor = System.Drawing.Color.Gray;
            this.downloadButton.BackgroundColor = System.Drawing.Color.Gray;
            this.downloadButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.downloadButton.BorderRadius = 5;
            this.downloadButton.BorderSize = 0;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Location = new System.Drawing.Point(12, 407);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(132, 37);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextColor = System.Drawing.Color.White;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.modsContainer);
            this.Controls.Add(this.downloadAll);
            this.Controls.Add(this.downloadSelected);
            this.Controls.Add(this.SettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Automatic Mod Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.RadioButton downloadSelected;
        private System.Windows.Forms.RadioButton downloadAll;
        private System.Windows.Forms.FlowLayoutPanel modsContainer;
        private CustomButton downloadButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

