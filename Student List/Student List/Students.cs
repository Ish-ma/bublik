using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_List
{
    [Serializable]
    class Students
    {
        public enum Gender { Мужской, Женский };

        public string Имя { get; set; }
        public Gender Пол { get; set; }
        public int Возраст { get; set; }
        public string Факультет { get; set; }
        public string Группа { get; set; }
        public int Курс { get; set; }

        public Students(String name = "", Gender g = Gender.Мужской, int age = 20, string faculty = "ИВТ", string group = "", int kurs = 1)
        {
            Имя = name;
            Пол = g;
            Возраст = age;
            Факультет = faculty;
            Группа = group;
            Курс = kurs;
        }
    }
}
