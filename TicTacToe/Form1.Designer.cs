namespace TicTacToe
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
            groupBox = new GroupBox();
            lblStatus = new Label();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnReset = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(lblStatus);
            groupBox.Controls.Add(btn9);
            groupBox.Controls.Add(btn8);
            groupBox.Controls.Add(btn7);
            groupBox.Controls.Add(btn6);
            groupBox.Controls.Add(btn5);
            groupBox.Controls.Add(btn4);
            groupBox.Controls.Add(btn3);
            groupBox.Controls.Add(btn2);
            groupBox.Controls.Add(btn1);
            groupBox.Location = new Point(94, 30);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(685, 473);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(323, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Tic Tac Toe";
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonFace;
            btn9.Location = new Point(442, 345);
            btn9.Name = "btn9";
            btn9.Size = new Size(107, 109);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonFace;
            btn8.Location = new Point(298, 345);
            btn8.Name = "btn8";
            btn8.Size = new Size(107, 109);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonFace;
            btn7.Location = new Point(154, 345);
            btn7.Name = "btn7";
            btn7.Size = new Size(107, 109);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonFace;
            btn6.Location = new Point(442, 212);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 109);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonFace;
            btn5.Location = new Point(298, 212);
            btn5.Name = "btn5";
            btn5.Size = new Size(107, 109);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonFace;
            btn4.Location = new Point(154, 212);
            btn4.Name = "btn4";
            btn4.Size = new Size(107, 109);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonFace;
            btn3.Location = new Point(442, 82);
            btn3.Name = "btn3";
            btn3.Size = new Size(107, 109);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonFace;
            btn2.Location = new Point(298, 82);
            btn2.Name = "btn2";
            btn2.Size = new Size(107, 109);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonFace;
            btn1.FlatAppearance.BorderSize = 3;
            btn1.Location = new Point(154, 82);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 109);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(392, 542);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(107, 38);
            btnReset.TabIndex = 10;
            btnReset.Text = "Restart Game";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 629);
            Controls.Add(btnReset);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Form1";
            
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Label lblStatus;
        private Button btnReset;
    }
}