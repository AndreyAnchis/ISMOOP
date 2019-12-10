using System;

namespace Human
{
    class Human
    {
        protected string Name;
        protected string Surname;
        protected DateTime BirthDay;
        public Human()
        {
            Name = "Не указан";
            Surname = "Не указан";
            BirthDay = DateTime.Now;
        }
        public Human(string name, string surname, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            BirthDay = Convert.ToDateTime(birthDay);
        }
        public Human(Human previousHuman)
        {
            Name = previousHuman.Name;
            Surname = previousHuman.Surname;
            BirthDay = previousHuman.BirthDay;
        }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public virtual string GetInfo()
        {
            return string.Format("Name: {0}, Surname: {1}, BirthDay: {2}", Name, Surname, BirthDay);
        }
    }

    class Abiturient : Human
    {
        protected int ZNO;
        protected int Certificate;
        protected string School;
        public Abiturient()
        {
            Name = "Не указан";
            Surname = "Не указан";
            BirthDay = DateTime.Now;
            ZNO = 100;
            Certificate = 0;
            School = "Не указан";
        }
        public Abiturient(string name, string surname, DateTime birthDay, int zno, int certificate, string school) :
            base(name, surname, birthDay)
        {
            ZNO = zno;
            Certificate = certificate;
            School = school;
        }
        public Abiturient(string name, string surname, int zno, string school) :
            base(name, surname)
        {
            Name = name;
            ZNO = zno;
            School = school;
        }
        public Abiturient(Abiturient previousAbiturient)
        {
            ZNO = previousAbiturient.ZNO;
            Certificate = previousAbiturient.Certificate;
            School = previousAbiturient.School;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Zno: " + ZNO + " Certificate: " + Certificate + " School: " + School;
        }
    }

    class Student : Human
    {
        protected int Course;
        protected int Group;
        protected string Fakulty;
        protected string University;
        public Student()
        {
            Name = "Не указан";
            Surname = "Не указан";
            BirthDay = DateTime.Now;
            Course = 0;
            Group = 0;
            Fakulty = "Не указан";
            University = "Не указан";
        }
        public Student(string name, string surname, DateTime birthDay, int course, int group, string fakulty, string university) :
           base(name, surname, birthDay)
        {
            Course = course;
            Group = group;
            Fakulty = fakulty;
            University = university;
        }
        public Student(Student previousStudent)
        {
            Course = previousStudent.Course;
            Group = previousStudent.Group;
            Fakulty = previousStudent.Fakulty;
            University = previousStudent.University;
        }
        public Student(string name, string surname, int course, int group, string university) :
           base(name, surname)
        {
            Course = course;
            Group = group;
            University = university;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Course: " + Course + " Group: " + Group + " Fakulty: " + Fakulty + " University: " + University;
        }
    }

    class Teacher : Human
    {
        protected string Position;
        protected string Department;
        protected string University;
        public Teacher()
        {
            Name = "Не указан";
            Surname = "Не указан";
            BirthDay = DateTime.Now;
            Position = "Не указан";
            Department = "Не указан";
            University = "Не указан";
        }
        public Teacher(string name, string surname, DateTime birthDay, string position, string department, string university) :
            base(name, surname, birthDay)
        {
            Position = position;
            Department = department;
            University = university;
        }
        public Teacher(Teacher previousTeacher)
        {
            Position = previousTeacher.Position;
            Department = previousTeacher.Department;
            University = previousTeacher.University;
        }
        public Teacher(string name, string surname, string position, string university) :
            base(name, surname)
        {
            Position = position;
            University = university;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Post: " + Position + " Kathedra: " + Department + " University: " + University;
        }
    }

    class LibraryUser : Human
    {
        protected int Number;
        protected DateTime Date;
        protected int Payment;
        public LibraryUser()
        {
            Name = "Не указан";
            Surname = "Не указан";
            BirthDay = DateTime.Now;
            Number = 0;
            Date = DateTime.Now;
            Payment = 0;
        }
        public LibraryUser(string name, string surname, DateTime dateOfBirth, int number, DateTime date, int payment) :
            base(name, surname, dateOfBirth)
        {
            Number = number;
            Date = Convert.ToDateTime(date);
            Payment = payment;
        }
        public LibraryUser(LibraryUser previousUser)
        {
            Number = previousUser.Number;
            Date = previousUser.Date;
            Payment = previousUser.Payment;
        }
        public LibraryUser(string name, string surname, int number, DateTime date) :
            base(name, surname)
        {
            Number = number;
            Date = Convert.ToDateTime(date);
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Number: " + Number + " Date: " + Date + " Payment: " + Payment + "UAH";
        }

    }

class Program
    {
        static void Main(string[] args)
        {
            Abiturient EmptyAbit = new Abiturient();
            Console.WriteLine(EmptyAbit.GetInfo());

            Abiturient abit = new Abiturient("Виталий", "Кличко", new DateTime(2000, 10, 10), 153, 11, "Школа №5");
            Console.WriteLine(abit.GetInfo());

            Abiturient CopyAbit = new Abiturient(abit);
            Console.WriteLine(CopyAbit.GetInfo());

            Abiturient NotFullAbit = new Abiturient("Виталий", "Кличко", 153, "Школа №5");
            Console.WriteLine(NotFullAbit.GetInfo());
            Console.WriteLine("\n");


            Student EmptyStud = new Student();
            Console.WriteLine(EmptyStud.GetInfo());
            Student Stud = new Student("Валентин", "Дорн", new DateTime(1995, 12, 27), 1, 1, "ФІКТ", "ЖДТУ");
            Console.WriteLine(Stud.GetInfo());
            Student CopyStud = new Student(Stud);
            Console.WriteLine(CopyStud.GetInfo());
            Student NotFullStud = new Student("Валентин", "Дорн", 1, 1, "ЖДТУ");
            Console.WriteLine(NotFullStud.GetInfo());
            Console.WriteLine("\n");


            Teacher EmptyTeach = new Teacher();
            Console.WriteLine(EmptyTeach.GetInfo());
            Teacher Teach = new Teacher("АННА", "Иванова", new DateTime(1985, 2, 7), "Декан", "ФІКТ", "ЖДТУ");
            Console.WriteLine(Teach.GetInfo());
            Teacher CopyTeach = new Teacher(Teach);
            Console.WriteLine(CopyTeach.GetInfo());
            Teacher NotFullTeach = new Teacher("Анна", "Иванова", "Декан", "ЖДТУ");
            Console.WriteLine(NotFullTeach.GetInfo());
            Console.WriteLine("\n");


            LibraryUser EmptyLib = new LibraryUser();
            Console.WriteLine(EmptyLib.GetInfo());
            LibraryUser Lib = new LibraryUser("Владислав", "Борисов", new DateTime(2003, 7, 14), 00125678, new DateTime(2019, 10, 24), 75);
            Console.WriteLine(Lib.GetInfo());
            LibraryUser CopyLib = new LibraryUser(Lib);
            Console.WriteLine(CopyLib.GetInfo());
            LibraryUser NotFullLib = new LibraryUser("Владислав", "Борисов", 09976443, new DateTime(2019, 3, 27));
            Console.WriteLine(NotFullLib.GetInfo());
            Console.WriteLine("\n");
        }
    }
}