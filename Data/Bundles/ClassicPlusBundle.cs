using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    class ClassicPlusBundle : IBundleTemplate
    {
        public ClassicPlusBundle(Answers answers)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young &&
                (answers.Income == IncomeEnum.Rich || answers.Income == IncomeEnum.Middle);
        }

        public int Value => 2;

        public bool IsApplicable { private set; get; }

        public string Name => Strings.ClassicPlus;

        public Type[] TemplateCreditCards =>
            new Type[]
            {
                typeof(DebitCard),
                typeof(CreditCard)
            };

        public Type TemplateAccount =>
            typeof(CurrentAccount);
    }
}
