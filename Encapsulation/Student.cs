using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        #region Types of  Property
        #region Full Property
        private int grade;
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                    grade = value;
            }
        }
        #endregion

        #region Auto Property
        public string Name { get; set; }
        //  Read-Only Property
        public int Id { get; }

        //  Static Property
        public static string SchoolName { get; set; }

        //  Computed Property (calculated value)
        public int Average
        {
            get
            {
                return (marks[0] + marks[1] + marks[2]) / 3;
            }
        }
        #endregion
        #region Indexer
        private int[] marks = new int[3];

        public int this[int index]
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }

        #endregion

        #endregion
        public Student(int id)
        {
            Id = id;
        }
    }
}
