namespace StudentClub
{
    public class Student
    {
        private string firstName;
        public string FirstName { get; set; }

        private string lastName;
        public string  LastName { get; set; }


        public string email;
        public string Email { get; set; }

      
        
        public Student(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        
        public override string ToString()
        {
           
            return $"{FirstName} {LastName} | {Email}";
        }
    }
}