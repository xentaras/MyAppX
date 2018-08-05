using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class CurrentAccount : Product
    {
        public CurrentAccount()
        {

        }

        protected override string GetName() => Strings.CurrentAccount;

        public override void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young &&
                answers.Income != IncomeEnum.Zero;

            if (IsApplicable != true)
            {
                var sb = new StringBuilder();

                if (answers.Age == AgeEnum.Young)
                    sb.AppendLine(Strings.TooYoung);
                if (answers.Income == IncomeEnum.Zero)
                    sb.AppendLine(Strings.TooPoor);

                WhyNot = sb.ToString();
            }
            else
            {
                WhyNot = Name;
            }
        }
    }
}
