using NUnit.Framework;
using System;

namespace NUnitTest_IndukRSP
{
    public class Tests
    {
        /// <summary>
        /// 초기 제한 시간 변수, 초기 이미지 변수
        /// </summary>
        private int seconds = 6; // 초기 시간
        private int check = 0; // 초기 
        private int show = 0; // 조건 1
        private int Rule = 0; // 조건 2

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

        private String teststr = "";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void RandomWord()
        {
            Random rand = new Random();
            int num = rand.Next(90);// 0 ~ 90 까지 랜덤정수를 저장

            if (0 <= num && num <= 29)
            { // 이겨주세요 조건 범위
                teststr = Rule_1;
            }
            else if (30 <= num && num <= 59)
            { // 비겨주세요 조건 범위
                teststr = Rule_2;
            }
            else
            { // 져주세요 조건 범위
                teststr = Rule_3;
            }
        }

        [Test]
        public void RandomPic()
        {
            Random rand = new Random();
            int num = rand.Next(90);// 0 ~ 90 까지 랜덤정수를 저장

            if (0 <= num && num <= 29)
            { // 바위 조건 범위
                check = 3;
            }
            else if (30 <= num && num <= 59)
            { // 가위 조건 범위
                check = 2;
            }
            else
            { // 보자기 조건 범위
                check = 1;
            }
        }

        [Test]
        public void checkRule()
        {
            int num = 3;
            if (num == 3)
            {
                if (teststr == Rule_1)
                {
                    if (check == 2)
                    {
                        Cnt += 10;

                    }
                }
                else if (teststr == Rule_2)
                {
                    if (check == 3)
                    {
                        Cnt += 10;

                    }
                }
                else
                {
                    if (check == 1)
                    {
                        Cnt += 10;

                    }
                }
            }
            else if (num == 2)
            {
                if (teststr == Rule_1)
                {
                    if (check == 1)
                    {
                        Cnt += 10;

                    }
                }
                else if (teststr == Rule_2)
                {
                    if (check == 2)
                    {
                        Cnt += 10;

                    }
                }
                else
                {
                    if (check == 3)
                    {
                        Cnt += 10;

                    }
                }
            }
            else
            {
                if (teststr == Rule_1)
                {
                    if (check == 3)
                    {
                        Cnt += 10;

                    }
                }
                else if (teststr == Rule_2)
                {
                    if (check == 1)
                    {
                        Cnt += 10;

                    }
                }
                else
                {
                    if (check == 2)
                    {
                        Cnt += 10;

                    }
                }
            }
        }
    }
}