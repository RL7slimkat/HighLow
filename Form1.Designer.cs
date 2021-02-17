namespace HighLow
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.NumericUpDown();
            this.lblAtt = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userInput)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Green;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(463, 151);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(189, 10);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 50;
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.BackColor = System.Drawing.Color.Black;
            this.btnGuess.FlatAppearance.BorderSize = 0;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuess.Location = new System.Drawing.Point(542, 503);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(558, 51);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "HighLow";
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.BackColor = System.Drawing.Color.Black;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Century Gothic", 115F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.userInput.Location = new System.Drawing.Point(420, 178);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(232, 191);
            this.userInput.TabIndex = 4;
            // 
            // lblAtt
            // 
            this.lblAtt.BackColor = System.Drawing.Color.Black;
            this.lblAtt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAtt.Location = new System.Drawing.Point(731, 179);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(97, 26);
            this.lblAtt.TabIndex = 5;
            this.lblAtt.Text = "Attempts";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Black;
            this.lblRes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRes.Location = new System.Drawing.Point(731, 282);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(105, 19);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Previous Temp";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblResult.Location = new System.Drawing.Point(764, 324);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 33);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "0";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.BackColor = System.Drawing.Color.Black;
            this.lblAttempts.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttempts.Location = new System.Drawing.Point(764, 215);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(30, 33);
            this.lblAttempts.TabIndex = 5;
            this.lblAttempts.Text = "0";
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestart.Location = new System.Drawing.Point(-1, 503);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(546, 51);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.GhostWhite;
            this.lblHeight.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(14, 48);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(276, 35);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Guess the temperature";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.Color.LightBlue;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(68, 503);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(76, 51);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::HighLow.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 552);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnGuess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HighLow";
            ((System.ComponentModel.ISupportInitialize)(this.userInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown userInput;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHelp;
    }
}

