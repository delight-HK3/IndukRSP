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
    public partial class Form1 : Form
    {
        /// <summary>
        /// 초기 제한 시간 변수, 초기 이미지 변수
        /// </summary>
        private int seconds = 6; // 초기 시간
        private int check = 0; // 초기 
        private int show = 0; // 조건 1
        private int Rule = 0; // 조건 2
        private int play = 0; //실행횟수

        /// <summary>
        /// 획득한 점수 및 맞춘 개수
        /// </summary>
        static public int Tot = 0;
        static public int Cnt = 0;

        /// <summary>
        /// 게임 조건
        /// </summary>
        private String Rule_1 = "이겨주세요";
        private String Rule_2 = "비겨주세요";
        private String Rule_3 = "져주세요";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 최초 실행시 시간은 1초씩 흐르게 한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            RandomPic();
            RandomWord();
            timer1.Start();
        }

        /// <summary>
        /// 타이머 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            seconds--;
            if (seconds == 0){
                RandomPic();
                RandomWord();
                seconds = 6;
            }
            label2.Text = seconds.ToString();

            //실행 횟수가 20회에 도달했는지 확인
            if (play >= 20)
            {
                timer1.Stop();

                Form2 from2 = new Form2();
                from2.Show();
                this.Hide();
            }
            playCount.Text = play.ToString();
        }

        /// <summary>
        /// 랜덤조건을 지정해주는 함수
        /// </summary>
        private void RandomWord(){
            Random rand = new Random();
            int num = rand.Next(90);// 0 ~ 90 까지 랜덤정수를 저장

            if (0 <= num && num <= 29){ // 이겨주세요 조건 범위
                question.Text = Rule_1;
            }
            else if (30 <= num && num <= 59){ // 비겨주세요 조건 범위
                question.Text = Rule_2;
            }
            else { // 져주세요 조건 범위
                question.Text = Rule_3;
            }
        }

        /// <summary>
        /// 랜덤이미지를 지정해주는 함수
        /// </summary>
        private void RandomPic()
        {
            Random rand = new Random();
            int num = rand.Next(90);// 0 ~ 90 까지 랜덤정수를 저장

            if (0 <= num && num <= 29) { // 바위 조건 범위
                check = 3;
                pictureBox.Image = Properties.Resources.Rock;
            }
            else if (30 <= num && num <= 59){ // 가위 조건 범위
                check = 2;
                pictureBox.Image = Properties.Resources.Scissors;
            }
            else { // 보자기 조건 범위
                check = 1;
                pictureBox.Image = Properties.Resources.Paper;
            }
        }

        /// <summary>
        /// 프로그램 종료 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        /// <summary>
        /// 자신이 무엇을 낼 지 골랐을 때, 점수를 획득할 수 있는지 조건 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rock_Click(object sender, EventArgs e)
        {
            if (play < 20)
            {
                play++;
                checkRule(3);

                RandomPic();
                RandomWord();
                seconds = 6;
            }
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            if (play < 20)
            {
                play++;
                checkRule(2);

                RandomPic();
                RandomWord();
                seconds = 6;
            }
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            if (play < 20)
            {
                play++;
                checkRule(1);

                RandomPic();
                RandomWord();
                seconds = 6;
            }
        }
       

        /// <summary>
        /// 점수 획득 조건 검사
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int checkRule(int num)
        {
            if (num == 3){
                if (question.Text == Rule_1){
                    if (check == 2){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else if (question.Text == Rule_2){
                    if (check == 3){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else{
                    if (check == 1){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
            }
            else if (num == 2)
            {
                if (question.Text == Rule_1){ 
                    if (check == 1){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else if (question.Text == Rule_2){
                    if (check == 2){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else {
                    if (check == 3){
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
            }
            else
            {
                if (question.Text == Rule_1)
                {
                    if (check == 3)
                    {
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else if (question.Text == Rule_2)
                {
                    if (check == 1)
                    {
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
                else
                {
                    if (check == 2)
                    {
                        Cnt += 5;
                        score.Text = Cnt.ToString();
                    }
                }
            }
            return 0;
        }

    }
}
