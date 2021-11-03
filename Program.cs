using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    enum Exams
    {
        Math,
        OOP,
        Philosophy,
        ComputerNetworks
    }

    struct Lecturer
    {
        public string Name;
        public string Subject;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  Subject: {Subject}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public abstract class Experiment
    {
        public abstract string GetTheme();

        public virtual DateTime GetDate()
        {
            return DateTime.Now.AddDays(7);
        }
    }

    class Test : Experiment, IQuestion
    {
        private string theme = "C#";
        private int[] answers = new int[10] { 2, 4, 1, 1, 3, 1, 4, 4, 1, 3 };

        public int CheckAnswer(int[] answers)
        {
            return 1;
        }

        string IQuestion.GetTheme()
        {
            return "Hello from interface";
        }

        public override string GetTheme()
        {
            return "Hello from class";
        }

        public override string ToString()
        {
            return theme;
        }
    }

    partial class Exam : Experiment
    {
        public Exam(string theme, string subject)
        {
            Theme = theme;
            Subject = subject;
        }

        public string Theme { get; set; }
        public string Subject { get; set; }
        public DateTime examDate = DateTime.Now.AddDays(12);
    }

    sealed class FinalExam : Exam
    {
        public FinalExam(string theme, string subject):base(theme, subject)
        {
            Theme = theme;
            Subject = subject;
        }

        public new string Theme { get; set; }
        public string Subject { get; set; }
        public override string ToString()
        {
            return this.Theme;
        }
    }

    class Printer
    {
        public void IAmPrinting(Experiment obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }

    public interface IQuestion
    {
        int CheckAnswer(int[] answers);
        string GetTheme();
    }
}
