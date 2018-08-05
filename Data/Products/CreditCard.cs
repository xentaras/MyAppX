using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class CreditCard : Product
    {
        public CreditCard()
        {
            
        }

        protected override string GetName() => Strings.CreditCard;

        public override void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts)
        {
            IsApplicable = 
                answers.Age != AgeEnum.Young && 
                (answers.Income == IncomeEnum.Middle || answers.Income == IncomeEnum.Rich);

            if (IsApplicable != true)
            {
                var sb = new StringBuilder();

                if (answers.Age == AgeEnum.Young)
                    sb.AppendLine(Strings.TooYoung);
                if (answers.Income == IncomeEnum.Zero || answers.Income == IncomeEnum.Poor)
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
