using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04.Images
{
    public class Students : IComparable<Students>
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public string Group { get; }
        public GenderStudents Gender { get; }
        public DateTime BirthDate { get; }

        public Students(string surname, string name, string patronymic, string group, GenderStudents gender, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Group = group;
            Gender = gender;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic}".Trim();
        }

        public string StringGenderStudent()
        {
            return Gender switch
            {
                GenderStudents.Male => "Мужской",
                GenderStudents.Female => "Женский",
                _ => "Не указан"
            };
        }

        public int CompareTo(Students other)
        {
            if (other == null) return 1;

            int surnameComparison = string.Compare(Surname, other.Surname, StringComparison.OrdinalIgnoreCase);
            if (surnameComparison != 0) return surnameComparison;

            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase); 
        }
    }
}