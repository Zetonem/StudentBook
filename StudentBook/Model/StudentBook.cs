using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBook.Model
{
    class StudentBook : ViewModelBase
    {
        #region PrivateClasses
        public struct Student
        {
            public FullName FullName { get; set; }
            public String Faculty { get; set; }
            public String Speciality { get; set; }
            public String Group { get; set; }
        };

        public struct Practice
        {
            public String Type { get; set; }
            public String Railway { get; set; }
            public String Place { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }

        public struct Review
        {
            public List<String> Work { get; set; }
            public String Relation { get; set; }
        }

        public struct Exam
        {
            public DateTime IssueDate { get; set; }
            public int Number { get; set; }
            public String SpecialityName { get; set; }
            public String Rank { get; set; }
            public ChairMark Mark { get; set; }
            public ProductionHead ProductionHead { get; set; }
            public ChairHead ChairHead { get; set; }
        }

        public struct FullName
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Patronymic { get; set; }
        }

        public struct ChairMark
        {
            public int Digit { get; set; }
            public String StringDigit { get; set; }
        }

        public struct ChairHead
        {
            public FullName FullName { get; set; }
            public String TelNumber { get; set; }
            public String Position { get; set; }
        }

        public struct ProductionHead
        {
            public FullName FullName { get; set; }
        }
        #endregion

        public Student StudentProperty { get; set; }
        public Practice PracticeProperty { get; set; }
        public Review ReviewProperty { get; set; }
        public Exam ExamProperty { get; set; }
    }
}
