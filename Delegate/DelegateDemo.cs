using System;
using NUnit.Framework;

namespace Subscribe
{
    public class DelegateDemo
    {
        public delegate void WeeklyCleanDelegate(int team);
        public delegate void WeeklyAllAnswerDelegate();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            WeeklyToDo weeklyToDo = new WeeklyToDo();
            WeeklyCleanDelegate team = new WeeklyCleanDelegate(weeklyToDo.CleanItem);
            // ����e��
            team(1);

            WeeklyAllAnswerDelegate write = new WeeklyAllAnswerDelegate(WeeklyToDo.WriteAllAnswer);
            write();
            Assert.Pass();
        }
    }

    public class WeeklyToDo
    {
        public void CleanItem(int team)
        {
            switch (team)
            {
                case 1:
                    Console.WriteLine("��a�O");
                    break;
                case 2:
                    Console.WriteLine("���a");
                    break;
                default:
                    Console.WriteLine("����l");
                    break;
            }
        }

        public static void WriteAllAnswer()
        {
            Console.WriteLine("Every one Write All Answer");
        }
    }
}