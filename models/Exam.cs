using System;

namespace lab2.models
{
    public class Exam
    {
        private string name { get; set; }
        private int mark{ get; set; }
        private DateTime date{ get; set; }

        public Exam(string name, int mark, DateTime date)
        {
            this.name = name;
            this.mark = mark;
            this.date = date;
        }

        public Exam()
        {
            name = "SOPROMAT";
            mark = 5;
            date = new DateTime();
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "Exam{"+ name + " " + mark + " " + date+"} ";
        }
    }
}