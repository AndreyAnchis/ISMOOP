using System;

namespace Worker
{
    class Worker
    {
        protected string Name { get; set; }
        protected int Year { get; set; }
        protected int Month { get; set; }
        protected int WorkedMonths;
        public Worker()
        {
            Name = "Не указан";
            Year = 0;
            Month = 0;
        }
        public Worker(string name, int year, int month)
        {
            Name = name;
            Year = year;
            Month = month; 
        }
        public Worker(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public Worker(Worker sameWorker)
        {
            Name = sameWorker.Name;
            Year = sameWorker.Year;
            Month = sameWorker.Month;

        }

        public void GetInfo()
        {
          //  WorkedMonths = GetWorkExperience(WorkedMonths);
            Console.WriteLine("Имя: {0}  Year: {1} Month: {2} WorkedMonths: {3}", Name, Year, Month, WorkedMonths);
        }
        public int GetWorkExperience(ref int result)
        {
            int timeNow, timeWas;
            timeNow = DateTime.Now.Year * 12 + DateTime.Now.Month;
            timeWas = Year * 12 + Month;
            result = timeNow - timeWas;
            return result;
        }

    }

    class Company
    {
        protected string Name { get; set; }
        protected string Position { get; set; }
        protected int Salary { get; set; }

        public Company()
        {
            Name = "Не указан";
            Position = "Не указан";
            Salary = 0;
        }
        public Company(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public Company (Company previousCompany)
        {
            Name = previousCompany.Name;
            Position = previousCompany.Position;
            Salary = previousCompany.Salary;

        }
        public Company(string position, int salary)
        {
            Position = position;
            Salary = salary;
        }
        public void GetInfo() {
                Console.WriteLine("Имя: {0}  Position: {1} Salary: {2}", Name, Position, Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // ref int dengy;
           // Worker.GetWorkExperience(dengy);
            Worker newWorker1 = new Worker();
            newWorker1.GetInfo();
            Worker newWorker2 = new Worker("Vasyl", 2019, 9);
            newWorker2.GetInfo();
            Worker newWorker3 = new Worker(2019, 5);
            newWorker3.GetInfo();
            Worker newWorker4 = new Worker(newWorker3);
            newWorker4.GetInfo();
            Company newcompany1 = new Company("ISM", "Developer", 1000);
            newcompany1.GetInfo();
            Company newcompany2 = new Company();
            newcompany2.GetInfo();
            Company newcompany3 = new Company("Web Designer", 1200);
            newcompany3.GetInfo();
            Company newcompany4 = new Company(newcompany1);
            newcompany4.GetInfo();



        }
    }
}
