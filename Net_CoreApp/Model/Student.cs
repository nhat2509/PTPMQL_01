namespace Net_CoreApp.Model
{
    public class Student
    {
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2024;
            return yearOfBirth - age;
        }
    }
}