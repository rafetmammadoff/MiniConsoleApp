using System;

namespace MiniConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Baku baku = new Baku();
            string option;
            do
            {
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Student elave et");
                Console.WriteLine("3. Employee-lerin sayini goster");
                Console.WriteLine("4. Student-lerin sayini goster");
                Console.WriteLine("5. Employee-lere bax");
                Console.WriteLine("6. Student-lere bax");
                Console.WriteLine("7. Insanlar uzerinde axtaris");
                Console.WriteLine("0. Menudan cix");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        string name;
                        string surname;
                        do
                        {
                            Console.WriteLine("Isci adini daxil edin");
                            name = Console.ReadLine();
                        } while (!Human.CheckNameAndSurname(name));

                        do
                        {
                            Console.WriteLine("Isci adini daxil edin");
                            surname = Console.ReadLine();
                        } while (!Human.CheckNameAndSurname(surname));
                        int age;
                        string ageStr;
                        do
                        {
                            Console.WriteLine("Isci yasini daxil edin");
                            ageStr = Console.ReadLine();
                        } while (!int.TryParse(ageStr,out age));

                        Console.WriteLine("Isci pozisiyasini daxil edin");
                        string position = Console.ReadLine();

                        Employee employee = new Employee(name,surname)
                        {
                            Age = age,
                            Position = position
                        };
                        baku.AddHuman(employee);
                        break;
                    case "2":
                        string nameS;
                        string surnameS;
                        do
                        {
                            Console.WriteLine("Student adini daxil edin");
                            nameS = Console.ReadLine();
                        } while (!Human.CheckNameAndSurname(nameS));

                        do
                        {
                            Console.WriteLine("Student soyadini daxil edin");
                            surnameS = Console.ReadLine();
                        } while (!Human.CheckNameAndSurname(surnameS));
                        int ageS;
                        string agesStr;
                        do
                        {
                            Console.WriteLine("Isci yasini daxil edin");
                            agesStr = Console.ReadLine();
                        } while (!int.TryParse(agesStr, out ageS));

                        int grade;
                        string gradeStr;
                        do
                        {
                            Console.WriteLine("Student qiymetini daxil edin");
                            gradeStr = Console.ReadLine();
                        } while (!int.TryParse(gradeStr, out grade));



                        Student student = new Student(nameS, surnameS)
                        {
                            Age = ageS,
                            Grade = grade
                        };
                        baku.AddHuman(student);
                        break;
                }



            } while (option != "0");
            
        }
    }
}
