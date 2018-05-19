using System;

namespace lab2.models
{
    public class Student
    {
        private Person person;
        private Education education;
        private int group;
        private Exam[] exams = new Exam[0];

        public Student(Person person, Education education, int @group)
        {
            this.person = person;
            this.education = education;
            this.group = group;
        }

        public Student()
        {
            person = new Person();
            education = Education.Specialist;
            group = 1;
        }

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        public Education Education
        {
            get { return education; }
            set { education = value; }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public Exam[] Exams
        {
            get { return exams; }
            set { exams = value; }
        }

        public double AvgMark
        {
            get
            {
                double mark = 0;
                foreach (var VARIABLE in Exams)
                {
                    mark += VARIABLE.Mark;
                }

                mark = Exams.Length > 0 ? mark / Exams.Length : 0;
                return mark;
            }
        }

        public void addExams(params Exam[] addExams)
        {
            Exam[] tmp = new Exam[exams.Length+addExams.Length];
            Array.Copy(exams, tmp, exams.Length);
            Array.Copy(addExams, 0, tmp, exams.Length, addExams.Length);
            exams = tmp;
        }

        public override string ToString()
        {
            string s = person + " Education " + education + " Group " + group+" Exams: ";
            for (int i = 0; i < exams.Length; i++)
            {
                s += exams[i].ToString();
            }

            return s;
        }

        public virtual string toShortString()
        {
            return person + " " + education + " " + group + " " + AvgMark;
        }
    }
}