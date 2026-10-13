namespace MyDailyMoodTracker
{
    partial class Form1
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
            lblTitle = new Label();
            btnHappy = new Button();
            btnSad = new Button();
            btnAngry = new Button();
            btnTired = new Button();
            btnLoved = new Button();
            lblMoodResult = new Label();
            lblMessage = new Label();
            btnSaveMood = new Button();
            lblHistory = new Label();
            lstMoodHistory = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MediumVioletRed;
            lblTitle.Location = new Point(232, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "How Are You Feeling Today?";
            // 
            // btnHappy
            // 
            btnHappy.BackColor = Color.LightPink;
            btnHappy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHappy.Location = new Point(70, 66);
            btnHappy.Name = "btnHappy";
            btnHappy.Size = new Size(120, 65);
            btnHappy.TabIndex = 1;
            btnHappy.Text = "😊 Happy";
            btnHappy.UseVisualStyleBackColor = false;
            btnHappy.Click += btnHappy_Click;
            // 
            // btnSad
            // 
            btnSad.BackColor = Color.LightPink;
            btnSad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSad.Location = new Point(206, 66);
            btnSad.Name = "btnSad";
            btnSad.Size = new Size(120, 65);
            btnSad.TabIndex = 2;
            btnSad.Text = "😢 Sad";
            btnSad.UseVisualStyleBackColor = false;
            btnSad.Click += btnSad_Click;
            // 
            // btnAngry
            // 
            btnAngry.BackColor = Color.LightPink;
            btnAngry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAngry.Location = new Point(341, 66);
            btnAngry.Name = "btnAngry";
            btnAngry.Size = new Size(120, 65);
            btnAngry.TabIndex = 3;
            btnAngry.Text = "😡 Angry";
            btnAngry.UseVisualStyleBackColor = false;
            btnAngry.Click += btnAngry_Click;
            // 
            // btnTired
            // 
            btnTired.BackColor = Color.LightPink;
            btnTired.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTired.Location = new Point(478, 66);
            btnTired.Name = "btnTired";
            btnTired.Size = new Size(120, 65);
            btnTired.TabIndex = 4;
            btnTired.Text = "😴 Tired";
            btnTired.UseVisualStyleBackColor = false;
            btnTired.Click += btnTired_Click;
            // 
            // btnLoved
            // 
            btnLoved.BackColor = Color.LightPink;
            btnLoved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoved.Location = new Point(614, 66);
            btnLoved.Name = "btnLoved";
            btnLoved.Size = new Size(120, 65);
            btnLoved.TabIndex = 5;
            btnLoved.Text = "\U0001f970 Loved";
            btnLoved.UseVisualStyleBackColor = false;
            btnLoved.Click += btnLoved_Click;
            // 
            // lblMoodResult
            // 
            lblMoodResult.AutoSize = true;
            lblMoodResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoodResult.Location = new Point(272, 150);
            lblMoodResult.Name = "lblMoodResult";
            lblMoodResult.Size = new Size(248, 28);
            lblMoodResult.TabIndex = 6;
            lblMoodResult.Text = "Select your mood above!";
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(97, 193);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(600, 70);
            lblMessage.TabIndex = 7;
            lblMessage.Text = "Your daily message will appear here.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveMood
            // 
            btnSaveMood.BackColor = Color.LightPink;
            btnSaveMood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveMood.Location = new Point(307, 278);
            btnSaveMood.Name = "btnSaveMood";
            btnSaveMood.Size = new Size(180, 50);
            btnSaveMood.TabIndex = 8;
            btnSaveMood.Text = "Save My Mood 💗";
            btnSaveMood.UseVisualStyleBackColor = false;
            btnSaveMood.Click += btnSaveMood_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.ForeColor = Color.MediumVioletRed;
            lblHistory.Location = new Point(290, 346);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(197, 25);
            lblHistory.TabIndex = 9;
            lblHistory.Text = "💕 My Mood History";
            // 
            // lstMoodHistory
            // 
            lstMoodHistory.FormattingEnabled = true;
            lstMoodHistory.IntegralHeight = false;
            lstMoodHistory.Location = new Point(97, 404);
            lstMoodHistory.Name = "lstMoodHistory";
            lstMoodHistory.Size = new Size(600, 120);
            lstMoodHistory.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 574);
            Controls.Add(lstMoodHistory);
            Controls.Add(lblHistory);
            Controls.Add(btnSaveMood);
            Controls.Add(lblMessage);
            Controls.Add(lblMoodResult);
            Controls.Add(btnLoved);
            Controls.Add(btnTired);
            Controls.Add(btnAngry);
            Controls.Add(btnSad);
            Controls.Add(btnHappy);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "My Daily Mood Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnHappy;
        private Button btnSad;
        private Button btnAngry;
        private Button btnTired;
        private Button btnLoved;
        private Label lblMoodResult;
        private Label lblMessage;
        private Button btnSaveMood;
        private Label lblHistory;
        private ListBox lstMoodHistory;
    }
}
