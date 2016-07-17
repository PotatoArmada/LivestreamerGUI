namespace LivestreamerGUI
{
    partial class Form1
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
            this.txtStreamName = new System.Windows.Forms.TextBox();
            this.btnStartStrem = new System.Windows.Forms.Button();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSaveStream = new System.Windows.Forms.Button();
            this.lstbxFavorites = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenChat = new System.Windows.Forms.Button();
            this.btnTwitchChannels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStreamName
            // 
            this.txtStreamName.Location = new System.Drawing.Point(12, 132);
            this.txtStreamName.Name = "txtStreamName";
            this.txtStreamName.Size = new System.Drawing.Size(209, 22);
            this.txtStreamName.TabIndex = 0;
            this.txtStreamName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStreamName_KeyDown);
            // 
            // btnStartStrem
            // 
            this.btnStartStrem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartStrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStrem.Location = new System.Drawing.Point(0, 225);
            this.btnStartStrem.Name = "btnStartStrem";
            this.btnStartStrem.Size = new System.Drawing.Size(341, 92);
            this.btnStartStrem.TabIndex = 1;
            this.btnStartStrem.Text = "Start";
            this.btnStartStrem.UseVisualStyleBackColor = true;
            this.btnStartStrem.Click += new System.EventHandler(this.btnStartStrem_Click);
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(227, 132);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 22);
            this.txtQuality.TabIndex = 2;
            this.txtQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuality_KeyDown);
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.Location = new System.Drawing.Point(93, 176);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 27);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnSaveStream
            // 
            this.btnSaveStream.AutoSize = true;
            this.btnSaveStream.Location = new System.Drawing.Point(12, 176);
            this.btnSaveStream.Name = "btnSaveStream";
            this.btnSaveStream.Size = new System.Drawing.Size(75, 27);
            this.btnSaveStream.TabIndex = 4;
            this.btnSaveStream.Text = "Save";
            this.btnSaveStream.UseVisualStyleBackColor = true;
            this.btnSaveStream.Click += new System.EventHandler(this.btnSaveStream_Click);
            // 
            // lstbxFavorites
            // 
            this.lstbxFavorites.FormattingEnabled = true;
            this.lstbxFavorites.ItemHeight = 16;
            this.lstbxFavorites.Location = new System.Drawing.Point(12, 12);
            this.lstbxFavorites.Name = "lstbxFavorites";
            this.lstbxFavorites.Size = new System.Drawing.Size(314, 84);
            this.lstbxFavorites.TabIndex = 5;
            this.lstbxFavorites.SelectedIndexChanged += new System.EventHandler(this.lstbxFavorites_SelectedIndexChanged);
            this.lstbxFavorites.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstbxFavorites_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channel Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quality:";
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.AutoSize = true;
            this.btnOpenChat.Location = new System.Drawing.Point(174, 176);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(75, 27);
            this.btnOpenChat.TabIndex = 8;
            this.btnOpenChat.Text = "Chat";
            this.btnOpenChat.UseVisualStyleBackColor = true;
            this.btnOpenChat.Click += new System.EventHandler(this.btnOpenChat_Click);
            // 
            // btnTwitchChannels
            // 
            this.btnTwitchChannels.AutoSize = true;
            this.btnTwitchChannels.Location = new System.Drawing.Point(255, 176);
            this.btnTwitchChannels.Name = "btnTwitchChannels";
            this.btnTwitchChannels.Size = new System.Drawing.Size(77, 27);
            this.btnTwitchChannels.TabIndex = 9;
            this.btnTwitchChannels.Text = "Channels";
            this.btnTwitchChannels.UseVisualStyleBackColor = true;
            this.btnTwitchChannels.Click += new System.EventHandler(this.btnTwitchChannels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 317);
            this.Controls.Add(this.btnTwitchChannels);
            this.Controls.Add(this.btnOpenChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxFavorites);
            this.Controls.Add(this.btnSaveStream);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.btnStartStrem);
            this.Controls.Add(this.txtStreamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Livestreamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreamName;
        private System.Windows.Forms.Button btnStartStrem;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSaveStream;
        private System.Windows.Forms.ListBox lstbxFavorites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenChat;
        private System.Windows.Forms.Button btnTwitchChannels;
    }
}

