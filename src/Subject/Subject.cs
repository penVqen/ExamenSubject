using System;
using System.Collections.Generic;
using System.Text;

namespace Subject
{
    class Subject
    {
        // Название
        public string Name;

        // Семестр
        public int Semester;

        // Форма аттестации
        public string FormCertification;

        public Subject () { }
        public Subject(string name, int semester, string formCertification)
        {
            Name = name;
            Semester = semester;
            FormCertification = formCertification;
        }
    }
}
