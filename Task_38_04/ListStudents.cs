using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Task_38_04.Images;

namespace Task_38_04
{
    public class ListStudents
    {
        private readonly List<Students> _students = new List<Students>();
        private const string SaveFileName = "students.json";

        public List<Students> Students => _students;

        public void AddStudent(Students student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            _students.Add(student);
            _students.Sort();
        }

        public void RemoveStudent(Students student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            if (!_students.Remove(student))
                throw new InvalidOperationException("Студент не найден в коллекции");
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string json = JsonSerializer.Serialize(_students, options);
            File.WriteAllText(SaveFileName, json);
        }

        public void Load()
        {
            if (!File.Exists(SaveFileName))
                return;

            string json = File.ReadAllText(SaveFileName);
            var loadedStudents = JsonSerializer.Deserialize<List<Students>>(json)
                               ?? new List<Students>();

            _students.Clear();
            _students.AddRange(loadedStudents);
            _students.Sort();
        }
    }
}