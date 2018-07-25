using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class CreditCard : IProduct
    {
        public CreditCard()
        {
            
        }

        public bool IsApplicable { private set; get; }

        public string Name => Strings.CreditCard;

        public bool IsSelected { get; set; }

        public void CheckIfApplicable(Answers answers, IProduct[] accounts)
        {
            IsApplicable = 
                answers.Age != AgeEnum.Young && 
                (answers.Income == IncomeEnum.Middle || answers.Income == IncomeEnum.Rich);
        }
    }
}
