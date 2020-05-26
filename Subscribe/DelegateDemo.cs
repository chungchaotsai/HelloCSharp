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
            // 執行委派
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
                    Console.WriteLine("拖地板");
                    break;
                case 2:
                    Console.WriteLine("掃地");
                    break;
                default:
                    Console.WriteLine("擦桌子");
                    break;
            }
        }

        public static void WriteAllAnswer()
        {
            Console.WriteLine("Every one Write All Answer");
        }
    }
}