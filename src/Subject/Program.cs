using System;

namespace Subject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество предметов:");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Введите корректное количество предметов (целое число больше 0)");
            }

            SubjectControl control = new SubjectControl(size);

            for (int i = 0; i < size; i++)
            {
                string name;

                do
                {
                    Console.WriteLine($"Введите название предмета номер {i + 1}");
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Введенно не коректное название");
                    }
                } while (string.IsNullOrEmpty(name));

                int semester;

                do
                {
                    Console.WriteLine("Введите семестр, в котором проводится предмет");
                    semester = int.Parse(Console.ReadLine());
                    if (semester > 10)
                    {
                        Console.WriteLine("Больше 10 семестров не бывает");
                    }
                } while (semester > 10);

                string formCertification;
                do
                {
                    Console.WriteLine("Введите форму аттестации (Устная, Письменная, Смешанная)");
                    formCertification = Console.ReadLine();
                    if (formCertification != "Устная" && formCertification != "Письменная" && formCertification != "Смешанная")
                    {
                        Console.WriteLine("Введена не коректная форма аттестации");
                    }
                } while (formCertification != "Устная" && formCertification != "Письменная" && formCertification != "Смешанная");

                    control.AddSubject(new Subject(name, semester, formCertification));
            }

            control.SortSubject();

            Console.WriteLine("Введите название файла, без расширение (по умолчанию .txt)");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("Введите путь сохранения файла, пример: D:\\Users\\stu-ipsp121\\Desktop\\subject");
            string filepath = Console.ReadLine();

            control.Save(filename, filepath);
        }
    }
}
