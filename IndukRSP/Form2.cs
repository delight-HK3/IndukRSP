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
    public partial class Form2 : Form 
    {
        private Form1 form1; // Form1 참조를 위한 변수
        public Form2()
        {
            InitializeComponent();
            Endscore.Text = Form1.Cnt.ToString();
            this.form1 = form1; // Form1 참조를 초기화
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1.Tot = 1;
        }

        private void gameReplay_Click(object sender, EventArgs e)
        {
            Application.Restart();  // 프로그램 재시작
        }

        private void gameExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

