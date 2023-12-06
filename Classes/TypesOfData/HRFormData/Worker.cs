using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.TypesOfData.HRFormData
{
    class Worker
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public DateTime Birth { get; set; }
        public long PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }
        public long CheckingAccount { get; set; }

        public Worker(int id, string surname, string name, string fName, DateTime birth, long phoneNumber, string jobTitle, DateTime employmentDate, double salary, long checkingAccount)
        {
            Id = id;
            Surname = surname;
            Name = name;
            FName = fName;
            Birth = birth;
            PhoneNumber = phoneNumber;
            JobTitle = jobTitle;
            EmploymentDate = employmentDate;
            Salary = salary;
            CheckingAccount = checkingAccount;
        }
    }
}
