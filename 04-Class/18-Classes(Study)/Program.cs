namespace _18_Classes_Study_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetStudent();
            Student student = new Student() { FirstName = "Recep", LastName = "Ersin", BirthDate = 1995, Id = 1905, Scholarship = true };
            Teacher teacher = new Teacher() { FirstName = "Murat", LastName = "Uluağaç", BirthDate = 1994, Id = 10044, Rank = "Prof", Salary = 105450 };

            List<Student> students = new List<Student>();
            students.Add(student);
            foreach (Student st in students)
            {
                Console.WriteLine($"ID: {st.Id} | Ad: {st.FullName} | Yaş: {st.BirthDate} | Burs: {(st.Scholarship ? "Burslu" : "Burssuz")}");
            }

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(teacher);
            foreach (Teacher tc in teachers)
            {
                Console.WriteLine($"ID: {tc.Id} | Ad: {tc.FullName} | Yaş: {tc.BirthDate} | Rank: {tc.Rank} | Salary: {tc.Salary}");
            }
        }
        static void GetStudent()
        {
            Console.Write("Lütfen öğrenci adını girin: ");
            string Name = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(Name))
            {
                Console.WriteLine(Name);
                
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yapıldı, lütfen harfler ile giriş yapın.");
                GetStudent();
            }
        }
    }
}
