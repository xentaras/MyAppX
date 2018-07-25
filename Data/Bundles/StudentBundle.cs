using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    class StudentBundle : IBundleTemplate
    {
        public StudentBundle(Answers answers)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young &&
                answers.Student == StudentEnum.Student;
        }

        public int Value => 0;

        public bool IsApplicable { private set; get; }

        public string Name => Strings.Student;

        public Type[] TemplateCreditCards =>
            new Type[]
            {
                typeof(DebitCard)
            };

        public Type TemplateAccount =>
            typeof(StudentAccount);
    }
}
