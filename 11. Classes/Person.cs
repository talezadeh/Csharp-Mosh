namespace ClassesTest
{
    public class Person
    {
        // private DateTime _birthDate;

        // public DateTime BirthDate
        // {
        //     get { return _birthDate; }
        //     set { _birthDate = value; }
        //  }


        // auto-implemented property
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; private set; }


        // Set birthdate once only
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }



        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}