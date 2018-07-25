namespace MyApp.Data
{
    public class StudentAccount : IProduct
    {
        public StudentAccount()
        {

        }

        public bool IsApplicable { private set; get; }

        public string Name => Strings.StudentAccount;

        public bool IsSelected { get; set; }

        public void CheckIfApplicable(Answers answers, IProduct[] accounts)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young && 
                answers.Student == StudentEnum.Student;
        }
    }
}
