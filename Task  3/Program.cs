namespace Task__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher("t1", "t2", 39);
            var student1 = new Student("s1", "s2", 21);


            teacher1.Explain();
            student1.Learning();
        }
    }
}