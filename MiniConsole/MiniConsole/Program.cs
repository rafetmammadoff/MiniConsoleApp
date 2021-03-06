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
                Selection();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        baku.AddHuman(EmployeInfoFromConsole());
                        break;
                    case "2":
                        baku.AddHuman(StudentInfoFromConsole());
                        break;
                    case "3":
                        Console.WriteLine($"Employelerin sayi - {baku.GetEmployees().Length}");
                        break;
                    case "4":
                        Console.WriteLine($"Studentlerin sayi - {baku.GetStudents().Length}");
                        break;
                    case "5":
                        ShowEmployee(baku);
                        break;
                    case "6":
                        ShowStudent(baku);
                        break;
                    case "7":
                        SearchHuman(baku);
                        break;
                    default:
                        Console.WriteLine("Yanlis deyer daxil edilib");
                        break;
                }
            } while (option != "0");
        }
        static void Selection()
        {
            Console.WriteLine("1. Employee elave et");
            Console.WriteLine("2. Student elave et");
            Console.WriteLine("3. Employee-lerin sayini goster");
            Console.WriteLine("4. Student-lerin sayini goster");
            Console.WriteLine("5. Employee-lere bax");
            Console.WriteLine("6. Student-lere bax");
            Console.WriteLine("7. Insanlar uzerinde axtaris");
            Console.WriteLine("0. Menudan cix");
        }

        static Employee EmployeInfoFromConsole()
        {
            string name;
            string surname;
            do
            {
                Console.WriteLine("Isci adini daxil edin");
                name = Console.ReadLine();
            } while (!Human.CheckNameAndSurname(name));

            do
            {
                Console.WriteLine("Isci soyadini daxil edin");
                surname = Console.ReadLine();
            } while (!Human.CheckNameAndSurname(surname));
            int age;
            string ageStr;
            do
            {
                Console.WriteLine("Isci yasini daxil edin");
                ageStr = Console.ReadLine();
            } while (!int.TryParse(ageStr, out age) || age < 17 || age > 90);

            Console.WriteLine("Isci pozisiyasini daxil edin");
            string position = Console.ReadLine();

            Employee employee = new Employee(name, surname)
            {
                Age = age,
                Position = position
            };

            return employee;
        }

        static Student StudentInfoFromConsole()
        {
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
            } while (!int.TryParse(agesStr, out ageS) || ageS < 6 || ageS > 90);

            int grade;
            string gradeStr;
            do
            {
                Console.WriteLine("Student qiymetini daxil edin");
                gradeStr = Console.ReadLine();
            } while (!int.TryParse(gradeStr, out grade) || grade < 0 || grade > 100);



            Student student = new Student(nameS, surnameS)
            {
                Age = ageS,
                Grade = grade
            };
            return student;
        }

        static void ShowEmployee(Baku baku)
        {
            for (int i = 0; i < baku.GetEmployees().Length; i++)
            {
                baku.GetEmployees()[i].ShowInfo();
            }
        }

        static void ShowStudent(Baku baku)
        {
            for (int i = 0; i < baku.GetStudents().Length; i++)
            {
                baku.GetStudents()[i].ShowInfo();
            }
        }

        static void SearchHuman(Baku baku)
        {
            Console.WriteLine("Axtaris deyerini daxil edin");
            string text = Console.ReadLine();
            for (int i = 0; i < baku.SearchHuman(text).Length; i++)
            {
                baku.SearchHuman(text)[i].ShowInfo();
            }
        }
    }
}
