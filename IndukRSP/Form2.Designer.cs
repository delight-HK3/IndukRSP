
namespace IndukRSP
{
    partial class Form2
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
            this.gameOver_label = new System.Windows.Forms.Label();
            this.gameReplay = new System.Windows.Forms.Button();
            this.gameExit = new System.Windows.Forms.Button();
            this.Endscore = new System.Windows.Forms.Label();
            this.Endscore_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOver_label
            // 
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOver_label.Location = new System.Drawing.Point(286, 76);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(125, 37);
            this.gameOver_label.TabIndex = 0;
            this.gameOver_label.Text = "게임종료";
            // 
            // gameReplay
            // 
            this.gameReplay.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameReplay.Location = new System.Drawing.Point(146, 203);
            this.gameReplay.Name = "gameReplay";
            this.gameReplay.Size = new System.Drawing.Size(143, 68);
            this.gameReplay.TabIndex = 1;
            this.gameReplay.Text = "다시하기";
            this.gameReplay.UseVisualStyleBackColor = true;
            this.gameReplay.Click += new System.EventHandler(this.gameReplay_Click);
            // 
            // gameExit
            // 
            this.gameExit.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameExit.Location = new System.Drawing.Point(406, 203);
            this.gameExit.Name = "gameExit";
            this.gameExit.Size = new System.Drawing.Size(143, 68);
            this.gameExit.TabIndex = 2;
            this.gameExit.Text = "나가기";
            this.gameExit.UseVisualStyleBackColor = true;
            this.gameExit.Click += new System.EventHandler(this.gameExit_Click);
            // 
            // Endscore
            // 
            this.Endscore.AutoSize = true;
            this.Endscore.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Endscore.Location = new System.Drawing.Point(408, 140);
            this.Endscore.Name = "Endscore";
            this.Endscore.Size = new System.Drawing.Size(33, 40);
            this.Endscore.TabIndex = 13;
            this.Endscore.Text = "0";
            this.Endscore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Endscore_label
            // 
            this.Endscore_label.AutoSize = true;
            this.Endscore_label.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Endscore_label.Location = new System.Drawing.Point(252, 140);
            this.Endscore_label.Name = "Endscore_label";
            this.Endscore_label.Size = new System.Drawing.Size(159, 40);
            this.Endscore_label.TabIndex = 14;
            this.Endscore_label.Text = "최종 점수 :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.Endscore_label);
            this.Controls.Add(this.Endscore);
            this.Controls.Add(this.gameExit);
            this.Controls.Add(this.gameReplay);
            this.Controls.Add(this.gameOver_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOver_label;
        private System.Windows.Forms.Button gameReplay;
        private System.Windows.Forms.Button gameExit;
        private System.Windows.Forms.Label Endscore;
        private System.Windows.Forms.Label Endscore_label;
    }
}