using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Mylib
{
    class student
    {
        public static ArrayList list = new ArrayList() { 473, "Иванов Иван Иванович", "ИСИП 20-11-1", "14.11.2002" };
        public static void vivod()
        {
            for (int i = 0; i < list.Count - 3; i += 4)
            {
                Console.WriteLine("Индекс студента: " + list[i] + "\nФИО студента: " + list[i + 1] + "\nГруппа студента: " + list[i + 2] + "\nДата рождения студента: " + list[i + 3] + "\n");
            }
        }
        public static void ADD(int index, string name, string group, string data)
        {
            list.Add(index);
            list.Add(name);
            list.Add(group);
            list.Add(data);
        }
        public static void Delete(int index)
        {
            for (int i = 0; i < list.Count - 2; i++)
            {
                if (list[i].ToString().Equals(index.ToString()))
                {
                    list.RemoveAt(i + 3);
                    list.RemoveAt(i + 2);
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    break;
                }
            }
        }
        public static void Fio()
        {
            for (int i = 1; i < list.Count - 2; i += 4)
            {
                Console.WriteLine("ФИО студента: " + list[i] + "\n");
            }
        }
        public static void PoiskID(int index)
        {
            for (int i = 0; i < list.Count - 3; i += 4)
            {
                if (list[i].ToString().Equals(index.ToString()))
                {
                    Console.WriteLine("Индекс студента: " + list[i] + "\nФИО студента: " + list[i + 1] + "\nГруппа студента: " + list[i + 2] + "\nДата рождения студента: " + list[i + 3] + "\n");
                    break;
                }
            }
        }
        public static void Years(int index)
        {
            string date = "";
            string DATE = "";
            for (int i = 0; i < list.Count - 2; i++)
            {
                if (list[i].ToString().Equals(index.ToString()))
                {
                    date += list[i + 3].ToString();
                    for (int j = 6; j < date.Length; j++)
                    {
                        DATE += date[j];
                    }
                    Convert.ToInt32(DATE);
                    Console.WriteLine(2021 - Convert.ToInt32(DATE));
                    break;
                }
            }
        }
    }
}
