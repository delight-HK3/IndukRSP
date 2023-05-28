
namespace IndukRSP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rock = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.score_label = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.FlatAppearance.BorderSize = 0;
            this.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(61, 433);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(110, 110);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Scissors
            // 
            this.Scissors.FlatAppearance.BorderSize = 0;
            this.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(333, 433);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(110, 110);
            this.Scissors.TabIndex = 1;
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.FlatAppearance.BorderSize = 0;
            this.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paper.Image = ((System.Drawing.Image)(resources.GetObject("Paper.Image")));
            this.Paper.Location = new System.Drawing.Point(639, 433);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(110, 110);
            this.Paper.TabIndex = 2;
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_label.Location = new System.Drawing.Point(619, 33);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(67, 30);
            this.score_label.TabIndex = 6;
            this.score_label.Text = "점수 :";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 60);
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question.Location = new System.Drawing.Point(256, 331);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(288, 40);
            this.question.TabIndex = 9;
            this.question.Text = "게임승리조건 레이블";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 86);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(345, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 110);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(682, 33);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(25, 30);
            this.score.TabIndex = 12;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "가위바위보";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label score;
    }
}

