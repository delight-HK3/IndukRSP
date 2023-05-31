using NUnit.Framework;
using System;

namespace NUnitTest_IndukRSP
{
    public class Tests
    {
        /// <summary>
        /// �ʱ� ���� �ð� ����, �ʱ� �̹��� ����
        /// </summary>
        private int seconds = 6; // �ʱ� �ð�
        private int check = 0; // �ʱ� 
        private int show = 0; // ���� 1
        private int Rule = 0; // ���� 2

        /// <summary>
        /// ȹ���� ���� �� ���� ����
        /// </summary>
        static public int Tot = 0;
        static public int Cnt = 0;

        /// <summary>
        /// ���� ����
        /// </summary>
        private String Rule_1 = "�̰��ּ���";
        private String Rule_2 = "����ּ���";
        private String Rule_3 = "���ּ���";

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
            int num = rand.Next(90);// 0 ~ 90 ���� ���������� ����

            if (0 <= num && num <= 29)
            { // �̰��ּ��� ���� ����
                teststr = Rule_1;
            }
            else if (30 <= num && num <= 59)
            { // ����ּ��� ���� ����
                teststr = Rule_2;
            }
            else
            { // ���ּ��� ���� ����
                teststr = Rule_3;
            }
        }

        [Test]
        public void RandomPic()
        {
            Random rand = new Random();
            int num = rand.Next(90);// 0 ~ 90 ���� ���������� ����

            if (0 <= num && num <= 29)
            { // ���� ���� ����
                check = 3;
            }
            else if (30 <= num && num <= 59)
            { // ���� ���� ����
                check = 2;
            }
            else
            { // ���ڱ� ���� ����
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