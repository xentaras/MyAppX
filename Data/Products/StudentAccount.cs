using System.Collections.Generic;
using System.Text;

namespace MyApp.Data
{
    public class StudentAccount : Product
    {
        public StudentAccount()
        {

        }

        protected override string GetName() => Strings.StudentAccount;

        public override void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young && 
                answers.Student == StudentEnum.Student;

            if (IsApplicable != true)
            {
                var sb = new StringBuilder();

                if (answers.Age == AgeEnum.Young)
                    sb.AppendLine(Strings.TooYoung);
                if (answers.Student == StudentEnum.NotStudent)
                    sb.AppendLine(Strings.NotStudent);

                WhyNot = sb.ToString();
            }
            else
            {
                WhyNot = Name;
            }
        }
    }
}
