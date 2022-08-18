namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthday;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthday = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthday;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}