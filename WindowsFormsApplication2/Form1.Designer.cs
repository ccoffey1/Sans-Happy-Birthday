namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sansDialogueText = new System.Windows.Forms.Label();
            this.chatBubbleImage = new System.Windows.Forms.PictureBox();
            this.engieSurpriseBox = new System.Windows.Forms.PictureBox();
            this.GUI = new System.Windows.Forms.PictureBox();
            this.sansBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chatBubbleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engieSurpriseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sansBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sansDialogueText
            // 
            this.sansDialogueText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sansDialogueText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sansDialogueText.Location = new System.Drawing.Point(777, 100);
            this.sansDialogueText.Name = "sansDialogueText";
            this.sansDialogueText.Size = new System.Drawing.Size(275, 136);
            this.sansDialogueText.TabIndex = 4;
            // 
            // chatBubbleImage
            // 
            this.chatBubbleImage.Image = global::WindowsFormsApplication2.Properties.Resources.sanschatbubble;
            this.chatBubbleImage.Location = new System.Drawing.Point(728, 78);
            this.chatBubbleImage.Name = "chatBubbleImage";
            this.chatBubbleImage.Size = new System.Drawing.Size(358, 184);
            this.chatBubbleImage.TabIndex = 3;
            this.chatBubbleImage.TabStop = false;
            // 
            // engieSurpriseBox
            // 
            this.engieSurpriseBox.Image = global::WindowsFormsApplication2.Properties.Resources.brandon;
            this.engieSurpriseBox.Location = new System.Drawing.Point(555, 463);
            this.engieSurpriseBox.Name = "engieSurpriseBox";
            this.engieSurpriseBox.Size = new System.Drawing.Size(59, 58);
            this.engieSurpriseBox.TabIndex = 1;
            this.engieSurpriseBox.TabStop = false;
            // 
            // GUI
            // 
            this.GUI.Image = ((System.Drawing.Image)(resources.GetObject("GUI.Image")));
            this.GUI.InitialImage = ((System.Drawing.Image)(resources.GetObject("GUI.InitialImage")));
            this.GUI.Location = new System.Drawing.Point(0, 0);
            this.GUI.Name = "GUI";
            this.GUI.Size = new System.Drawing.Size(1165, 776);
            this.GUI.TabIndex = 0;
            this.GUI.TabStop = false;
            // 
            // sansBox
            // 
            this.sansBox.Image = global::WindowsFormsApplication2.Properties.Resources.sans_normal;
            this.sansBox.Location = new System.Drawing.Point(433, 49);
            this.sansBox.Name = "sansBox";
            this.sansBox.Size = new System.Drawing.Size(298, 290);
            this.sansBox.TabIndex = 5;
            this.sansBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1165, 776);
            this.Controls.Add(this.sansBox);
            this.Controls.Add(this.sansDialogueText);
            this.Controls.Add(this.chatBubbleImage);
            this.Controls.Add(this.engieSurpriseBox);
            this.Controls.Add(this.GUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(595, 338);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "huhhu";
            ((System.ComponentModel.ISupportInitialize)(this.chatBubbleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engieSurpriseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sansBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GUI;
        public System.Windows.Forms.PictureBox engieSurpriseBox;
        private System.Windows.Forms.PictureBox chatBubbleImage;
        private System.Windows.Forms.Label sansDialogueText;
        private System.Windows.Forms.PictureBox sansBox;
    }
}

