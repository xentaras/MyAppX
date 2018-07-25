using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class Answers
    {
        public Answers(int age, bool student, decimal income)
        {
            SetAge(age);
            SetStudent(student);
            SetIncome(income);
        }

        public AgeEnum Age { get; private set; }

        public StudentEnum Student { get; private set; }

        public IncomeEnum Income { get; private set; }

        private void SetAge(int age)
        {
            if (age < 18)
                Age = AgeEnum.Young;
            else if (age > 65)
                Age = AgeEnum.Old;
            else
                Age = AgeEnum.Middle;
        }

        private void SetStudent(bool student)
        {
            Student = student ? StudentEnum.Student : StudentEnum.NotStudent;
        }

        private void SetIncome(decimal income)
        {
            if (income == 0)
                Income = IncomeEnum.Zero;
            else if (income < 12001)
                Income = IncomeEnum.Poor;
            else if (income < 40001)
                Income = IncomeEnum.Middle;
            else
                Income = IncomeEnum.Rich;
        }
    }
}
