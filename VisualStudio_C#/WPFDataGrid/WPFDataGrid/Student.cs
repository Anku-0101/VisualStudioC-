using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataGrid
{
   public class Student
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private bool isSoccerPlayer;
        public bool IsSoccerPlayer
        {
            get
            {
                return isSoccerPlayer;
            }

            set
            {
                isSoccerPlayer = value;
            }
        }

        private Gender gender;
        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public static ObservableCollection<Student> GetStudent()
        {
            var studentColl = new ObservableCollection<Student>();

            studentColl.Add(new Student() { Id = 007, Name = "James Bond", IsSoccerPlayer = true, Gender = Gender.Male });
            studentColl.Add(new Student() { Id = 009, Name = "Peter Parker", IsSoccerPlayer = true, Gender = Gender.Male });
            studentColl.Add(new Student() { Id = 017, Name = "Emma Stone", IsSoccerPlayer = true, Gender = Gender.Female });
            studentColl.Add(new Student() { Id = 005, Name = "Cathlene Tate", IsSoccerPlayer = false, Gender = Gender.Female });
            studentColl.Add(new Student() { Id = 087, Name = "Steve Corell", IsSoccerPlayer =false, Gender = Gender.Male });

            return studentColl;
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
