namespace HarryPotter
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.BeginButton = new System.Windows.Forms.Button();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PHealthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HorcruxesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Interval = 1000;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(713, 415);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 23);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "Begin";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 80;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.Location = new System.Drawing.Point(636, 9);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(100, 17);
            this.EnemyLabel.TabIndex = 1;
            this.EnemyLabel.Text = "Enemy Health:";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HealthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HealthLabel.Location = new System.Drawing.Point(742, 9);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(34, 19);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "100";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(12, 9);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(97, 17);
            this.PlayerLabel.TabIndex = 3;
            this.PlayerLabel.Text = "Player Health:";
            // 
            // PHealthLabel
            // 
            this.PHealthLabel.AutoSize = true;
            this.PHealthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PHealthLabel.Location = new System.Drawing.Point(116, 8);
            this.PHealthLabel.Name = "PHealthLabel";
            this.PHealthLabel.Size = new System.Drawing.Size(34, 19);
            this.PHealthLabel.TabIndex = 4;
            this.PHealthLabel.Text = "100";
            this.PHealthLabel.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Horcruxes Found: ";
            // 
            // HorcruxesLabel
            // 
            this.HorcruxesLabel.AutoSize = true;
            this.HorcruxesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorcruxesLabel.Location = new System.Drawing.Point(309, 8);
            this.HorcruxesLabel.Name = "HorcruxesLabel";
            this.HorcruxesLabel.Size = new System.Drawing.Size(18, 19);
            this.HorcruxesLabel.TabIndex = 6;
            this.HorcruxesLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HorcruxesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PHealthLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.BeginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label PHealthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HorcruxesLabel;
    }
}

