using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Subject
{
    class SubjectControl
    {
        private Subject[] subjects;
        private int subjectCount;

        public SubjectControl(int size)
        {
            subjects = new Subject[size];
            subjectCount = 0;
        }

        public void AddSubject(Subject subject)
        {
            if (subjectCount < subjects.Length)
            {
                subjects[subjectCount++] = subject;
            }
            else
            {
                Console.WriteLine("Массив переполнен");
            }
        }

        public void SortSubject()
        {
            subjects = subjects
                .OrderByDescending(f => f.FormCertification)
                .ThenByDescending(n => n.Name)
                .ToArray();
        }

        public void Save(string filename, string filepath)
        {
            string fullPath = Path.Combine(filename, filepath);
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                foreach (Subject subject in subjects)
                {
                    sw.WriteLine($"Название: {subject.Name}, Семестр: {subject.Name}, Форма аттестации: {subject.FormCertification}");
                }
            }
        }
    }
}
