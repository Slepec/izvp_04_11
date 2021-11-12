using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_04_11
{
    public class Student
    {
        private string name;
        private int year;
        private int groupNumber;
        private int physics;
        private int math;
        private int inf;
        private int chemistry;
        private double avg;

        public Student(string name, int year, int groupNumber, int physics, int math, int inf, int chemistry, double avg)
        {
            this.name = name;
            this.year = year;
            this.groupNumber = groupNumber;
            this.physics = physics;
            this.math = math;
            this.inf = inf;
            this.chemistry = chemistry;
            this.avg = avg;
        }
        public Boolean isTopStudent()
        {
            if (physics < 4 || inf < 4 || math < 4 || chemistry < 4) return false;
            return true;
        }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public int GroupNumber { get => groupNumber; set => groupNumber = value; }
        public int Physics { get => physics; set => physics = value; }
        public int Math { get => math; set => math = value; }
        public int Inf { get => inf; set => inf = value; }
        public int Chemistry { get => chemistry; set => chemistry = value; }
        public double Avg { get => avg; set => avg = value; }
    }
}
