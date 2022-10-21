using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




struct citizen
{
    public string name;
    public int pasport;
    public int number_problem;
    public string problem;
    public int scandal;
    public int mind;
}
namespace DZ._14._10._2022
{
    internal class Program
    {



        static string Сomparison(int[] mas1, int[] mas2)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] == 5)
                {
                    count1++;
                }
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                if (mas2[i] == 5)
                {
                    count2++;
                }
            }
            if (count1 == count2)
            {
                return "Drinks All Round! Free Beers on Bjorg!";
            }
            else
            {
                return "Ой, Бьорг - пончик! Ни для кого пива!";
            }

        }
        static void Main(string[] args)
        {

            /* string[] stud1 = { "Иван", "Иванов", "12.12.2004", "математика", "98" };
             string[] stud2 = { "Настя", "Петрушкина", "13.12.2005", "математика", "96" };
             string[] stud3 = { "Адэль", "Галяутдинов", "14.12.2006", "математика", "60" };
             string[] stud4 = { "Айрат", "Киров", "15.12.2004", "математика", "93" };
             string[] stud5 = { "Ирина", "Вахитова", "16.12.2007", "математика", "85" };
             string[] stud6 = { "Тимур", "Воронин", "17.12.2008", "математика", "91" };
             string[] stud7 = { "Кристина", "Калимулина", "18.12.2009", "математика", "20" };
             string[] stud8 = { "Шахмухид", "Карим", "19.12.2010", "математика", "80" };
             string[] stud9 = { "Рафаэль", "Комаров", "20.12.2011", "математика", "90" };
             string[] stud10 = { "Ильяс", "Золотарев", "21.12.2012", "математика", "70" };


             var people = new Dictionary<int,string[]>()
             {

             };
             people.Add(1, stud1);
             people.Add(2, stud2);
             people.Add(3, stud3);
             people.Add(4, stud4);
             people.Add(5, stud5);
             people.Add(6, stud6);
             people.Add(7, stud7);
             people.Add(8, stud8);
             people.Add(9, stud9);
             people.Add(10, stud10);
             Console.WriteLine("Меню:" + '\n' + "Выберите: Новый студент ; Удалить ; Сортировать");
             string word = Console.ReadLine();
             if (word == "Новый студент")
             {
                 Console.WriteLine("Введите информацию о студенте: Фамилия, Имя, Год рождения, Экзамен, Баллы");

                 string[] newstud = new string[5];

                 for (int i = 0; i < 5; i++)
                 {
                     newstud[i] = Console.ReadLine();
                 }

                 people.Add(11, newstud);
                 foreach (var person in people)
                 {
                     Console.WriteLine(person.Value[0] + " " + person.Value[1] + " " + person.Value[2] + " " + person.Value[3] + " " + person.Value[4]);
                 }


             }
             else if (word == "у")
             {
                 Console.WriteLine("Введите имя студента,которого хотите удалить");
                 string name = Console.ReadLine();
                 Console.WriteLine("Введите фамилию студента,которого хотите удалить");
                 string secondname = Console.ReadLine();

                 for (int i = 1; i <= people.Count; i++)
                 {

                     if (people[i][0] == name && people[i][1] == secondname)
                     {

                         people.Remove(i);


                     }

                 }
                 foreach (var person in people)
                 {
                     Console.WriteLine(person.Value[0] + " " + person.Value[1] + " " + person.Value[2] + " " + person.Value[3] + " " + person.Value[4]);
                 }



             }
             else if (word == "Сортировать")
             {
                 string [] temp;
                 for (int i = 1; i <= people.Count; i++)
                 {
                     for (int j = i + 1; j <= people.Count; j++)
                     {
                         if (Convert.ToInt32(people[i][4]) > Convert.ToInt32(people[j][4]))
                         {
                             temp = people[i];
                             people[i] = people[j];
                             people[j] = temp;
                         }
                     }
                 }
                 foreach (var person in people)
                 {
                     Console.WriteLine(person.Value[0] + " " + person.Value[1] + " " + person.Value[2]+ " " + person.Value[3] + " " + person.Value[4]);
                 }

             }





             Console.WriteLine("ДЗ. Задача 2");
             int[] mas1 = new int[10];
             int[] mas2 = new int[10];
             Console.WriteLine("Введите элементы 1 массива");
             for(int i =0; i < mas1.Length; i++)
             {
                 try
                 {
                     mas1[i] = int.Parse(Console.ReadLine());
                 }
                 catch
                 {
                     Console.WriteLine("Введено не число");
                     return;

                 }
             }

             Console.WriteLine("Введите элементы 2 массива");
             for (int i = 0; i < mas2.Length; i++)
             {
                 try
                 {
                     mas2[i] = int.Parse(Console.ReadLine());
                 }
                 catch
                 {
                     Console.WriteLine("Введено не число");
                     return;
                 }
             }

             Console.WriteLine(Сomparison(mas1, mas2));

             Console.WriteLine("ДЗ. Задача 3");
             Console.WriteLine("Окно 1 - оплата" + '\n' + "Окно 2 - подключение" + '\n' + " Окно 3 - отопление");
             Console.WriteLine("Заполните форму клиента");
             citizen Kirill = new citizen();
             Console.WriteLine("Введите имя");
             Kirill.name = Console.ReadLine();
             Console.WriteLine("Введите номер паспорта");
             Kirill.pasport = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите номер проблемы от 1 до 3");
             Kirill.number_problem = int.Parse(Console.ReadLine());
             Console.WriteLine("Опишите проблему");
             Kirill.problem = Console.ReadLine();
             Console.WriteLine("Введите уровень скандальности. 10 - скандальный урод, 0 - паинька");
             Kirill.scandal = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите степень развития. 1 - умный, 0 - отсталый");
             Kirill.mind = int.Parse(Console.ReadLine());


             var massiv = Kirill.problem.Split();

             foreach (var word1 in massiv)
             {

                 if (word1 == "оплата" || word1 == "Оплата" || word1 == "ОПЛАТА")
                 {
                     Console.WriteLine("Вам в 1 окно");
                     break;
                 }
                 else if (word1 == "подключение" || word1 == "Подключение" || word1 == "ПОДКЛЮЧЕНИЕ")
                 {
                     Console.WriteLine("Вам во 2 окно");
                     break;
                 }
                 else if (word1 == "отопление" || word1 == "Отопление" || word1 == "ОТОПЛЕНИЕ")
                 {
                     Console.WriteLine("Вам в 3 окно");
                     break;
                 }

             }

             if (Kirill.scandal >= 5)
             {
                 Console.WriteLine("Сколько человек из очереди длиной 15 обгонит скандалист?");
                 int peoplecount = int.Parse(Console.ReadLine());
                 if (peoplecount > 10 || peoplecount < 0)
                 {
                     Console.WriteLine("Указано неверное количество людей в очереди");
                 }
                 else
                 {

                     if (Kirill.mind == 0)
                     {
                         Random random = new Random();
                         int room;
                         room = random.Next(1, 3);
                         Console.WriteLine(Kirill.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n' +
                      " ,но " + Kirill.name + " тупой " + " и вместо нужного окна встал в " + room + " окно");
                     }

                     else
                     {
                         Console.WriteLine(Kirill.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n');
                     }
                 }
             }
             else
             {
                 if (Kirill.mind == 0)
                 {
                     Random random = new Random();
                     int room;
                     room = random.Next(1, 3);
                     Console.WriteLine(Kirill.name + " - паинька , но тупой , поэтому вместо своего окна встал в " + room + " окно");
                 }
                 else
                 {
                     Console.WriteLine(Kirill.name + "не тупой, поэтому встал в " + Kirill.number_problem + " окно");
                 }
             }



             Console.WriteLine("Задание 4, обход графа в ширину");
             Random rand = new Random();
             Queue<int> NomersVersh = new Queue<int>();
             Console.Write("Введите количество вершин: ");
             int CountVersh = int.Parse(Console.ReadLine()) - 1;
             if (CountVersh >= 3)
             {
                 bool[] UsedVersh = new bool[CountVersh + 1];
                 int[][] SmezhVersh = new int[CountVersh + 1][];

                 for (int i = 0; i < CountVersh + 1; i++)
                 {
                     SmezhVersh[i] = new int[CountVersh + 1];
                     Console.Write($"\n{i + 1} вершина - [");
                     for (int j = 0; j < CountVersh + 1; j++)
                     {
                         SmezhVersh[i][j] = rand.Next(0, 2);
                     }
                     SmezhVersh[i][i] = 0;
                     foreach (var item in SmezhVersh[i])
                     {
                         Console.Write($" {item}");
                     }
                     Console.Write("]\n");
                 }
                 UsedVersh[CountVersh] = true;     //информация о том, посещали мы вершину или нет 
                 NomersVersh.Enqueue(CountVersh);
                 Console.WriteLine("Начинаем обход с {0} вершины", CountVersh + 1);
                 while (NomersVersh.Count != 0)
                 {
                     CountVersh = NomersVersh.Peek();
                     NomersVersh.Dequeue();
                     Console.WriteLine("Перешли к узлу {0}", CountVersh + 1);

                     for (int i = 0; i < SmezhVersh.Length; i++)
                     {
                         if (Convert.ToBoolean(SmezhVersh[CountVersh][i]))
                         {
                             int v = i;
                             if (!UsedVersh[v])
                             {
                                 UsedVersh[v] = true;
                                 NomersVersh.Enqueue(v);
                                 Console.WriteLine("Добавили в очередь узел {0}", v + 1);
                             }
                         }



                     }
                 }

             }*/

            Queue<int> peak = new Queue<int>();
            



        }
    }     
    
}
