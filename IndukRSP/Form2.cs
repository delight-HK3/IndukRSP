using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IndukRSP
{
    /// <summary>
    /// @brief 종료 화면
    /// @details 획득한 점수를 확인하고 재시작 혹은 종료 가능
    /// @date 2023-05-30
    /// </summary>
    public partial class Form2 : Form 
    {
        private Form1 form1; // Form1 참조를 위한 변수

        /// <summary>
        /// Form2 실행
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            Endscore.Text = Form1.Cnt.ToString();   /// 획득한 점수를 레이블에 전달하여 출력
            this.form1 = form1; /// Form1 참조를 초기화
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1.Tot = 1;
        }

        private void gameReplay_Click(object sender, EventArgs e)
        {
            Application.Restart();  /// 프로그램 재시작
        }

        private void gameExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

