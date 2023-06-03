namespace Minecraft_Automatic_ModDownloader
{
    partial class Settings
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
            this.closeSettingsButton = new System.Windows.Forms.Button();
            this.Drag = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.generalButton = new Minecraft_Automatic_ModDownloader.CustomButton();
            this.Drag.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeSettingsButton
            // 
            this.closeSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.closeSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeSettingsButton.FlatAppearance.BorderSize = 0;
            this.closeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSettingsButton.ForeColor = System.Drawing.Color.White;
            this.closeSettingsButton.Location = new System.Drawing.Point(546, 0);
            this.closeSettingsButton.Name = "closeSettingsButton";
            this.closeSettingsButton.Size = new System.Drawing.Size(32, 32);
            this.closeSettingsButton.TabIndex = 9;
            this.closeSettingsButton.Text = "X";
            this.closeSettingsButton.UseVisualStyleBackColor = false;
            this.closeSettingsButton.Click += new System.EventHandler(this.closeSettingsButton_Click);
            this.closeSettingsButton.MouseEnter += new System.EventHandler(this.closeSettingsButton_MouseEnter);
            this.closeSettingsButton.MouseLeave += new System.EventHandler(this.closeSettingsButton_MouseLeave);
            // 
            // Drag
            // 
            this.Drag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Drag.Controls.Add(this.closeSettingsButton);
            this.Drag.Cursor = System.Windows.Forms.Cursors.Default;
            this.Drag.Location = new System.Drawing.Point(0, -2);
            this.Drag.Name = "Drag";
            this.Drag.Size = new System.Drawing.Size(578, 39);
            this.Drag.TabIndex = 8;
            this.Drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(0, 79);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(578, 370);
            this.panelContainer.TabIndex = 10;
            // 
            // generalButton
            // 
            this.generalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.generalButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.generalButton.BorderColor = System.Drawing.Color.Transparent;
            this.generalButton.BorderRadius = 0;
            this.generalButton.BorderSize = 0;
            this.generalButton.FlatAppearance.BorderSize = 0;
            this.generalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalButton.ForeColor = System.Drawing.Color.White;
            this.generalButton.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.generalButton.Location = new System.Drawing.Point(0, 36);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(119, 45);
            this.generalButton.TabIndex = 0;
            this.generalButton.Text = "General";
            this.generalButton.TextColor = System.Drawing.Color.White;
            this.generalButton.UseVisualStyleBackColor = false;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.Drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Drag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeSettingsButton;
        private System.Windows.Forms.Panel Drag;
        private System.Windows.Forms.Panel panelContainer;
        private CustomButton generalButton;
    }
}