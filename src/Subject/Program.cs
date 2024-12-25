using System;

namespace Subject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество предметов:\n");
            int size = int.Parse(Console.ReadLine());

            SubjectControl control = new SubjectControl(size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите название предмета номер {i+1}");
                string name = Console.ReadLine();

                Console.WriteLine("Введите семестр, в котором проводится предмет");
                int semester = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите форму аттестации (Устная, Письменная, Смешанная)");
                string formCertification = Console.ReadLine();

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
