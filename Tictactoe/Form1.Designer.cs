namespace Tictactoe
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
            button1 = new Button();
            lblStatus = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button9 = new Button();
            btnReset = new Button();
            btnMultiplayer = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(69, 80);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(69, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Click += Button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(164, 80);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(260, 80);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(69, 176);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(164, 176);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(164, 276);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(69, 276);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(260, 176);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(260, 276);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(254, 392);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnMultiplayer
            // 
            btnMultiplayer.Location = new Point(69, 392);
            btnMultiplayer.Name = "btnMultiplayer";
            btnMultiplayer.Size = new Size(135, 23);
            btnMultiplayer.TabIndex = 11;
            btnMultiplayer.Text = "Multiplayer mode: off";
            btnMultiplayer.UseVisualStyleBackColor = true;
            btnMultiplayer.Click += btnMultiplayer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(btnMultiplayer);
            Controls.Add(btnReset);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblStatus;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button9;
        private Button btnReset;
        private Button btnMultiplayer;
    }
}
