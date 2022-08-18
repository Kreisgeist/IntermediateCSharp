namespace Properties
{
    internal partial class Program
    {
        public class Person
        {
            public DateTime Birthdate { get; private set; }
            public string Name { get; set; }
            public string Username { get; set; }

            public Person(DateTime birthdate)
            {
                Birthdate = birthdate;
            }

            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days / 365;

                    return years;
                }
            }
        }
    }
}