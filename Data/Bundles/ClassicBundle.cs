using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    class ClassicBundle : IBundleTemplate
    {
        public ClassicBundle(Answers answers)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young &&
                answers.Income != IncomeEnum.Zero;
        }

        public int Value => 1;

        public bool IsApplicable { private set; get; }

        public string Name => Strings.Classic;

        public Type[] TemplateCreditCards =>
            new Type[]
            {
                typeof(DebitCard)
            };

        public Type TemplateAccount =>
            typeof(CurrentAccount);
    }
}
