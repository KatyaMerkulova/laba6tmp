using System;

namespace lb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, group, sstatus;
            string name, lastname,status, fakultet;
            string path = @"C:\Users\katem\OneDrive\Рабочий стол\f1.txt";
            int expelled1 = 0;
            int expelled2 = 0;
            int expelled3 = 0;
            int expelled4 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
            int k = int.Parse(Console.ReadLine());
            while (k != 7)
            {
                List<string> list1 = new List<string>();
                List<second_grade> list2 = new List<second_grade>();
                List<third_grade> list3 = new List<third_grade>();
                List<fourth_grade> list4 = new List<fourth_grade>();

                if (k == 1)
                {
                    Console.WriteLine("На какой курс добавить? 1,2,3,4");
                    a = int.Parse(Console.ReadLine());
                    while ((a != 1) && (a != 2) && (a != 3) && (a != 4))
                    {
                        Console.WriteLine("Недопустимое значение, выберите 1 или 2 или 3 или 4");
                        a = int.Parse(Console.ReadLine());
                       
                    }
                    if (a == 1)
                    {
                        b1++;
                        Console.WriteLine("введите имя студента");
                        name = Console.ReadLine();
                        Console.WriteLine("введите фамилию студента");
                        lastname = Console.ReadLine();
                        Console.WriteLine("введите группу студента: 1 или 2");
                        group = int.Parse(Console.ReadLine());
                        while ((group != 1) && (group != 2))
                        {
                            Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                            group = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                        sstatus = int.Parse(Console.ReadLine());
                        while ((sstatus != 1) && (sstatus != 2))
                        {
                            Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                            sstatus = int.Parse(Console.ReadLine());
                        }
                        if (sstatus == 1) { status = "учится "; }
                        else { expelled1++; status = "отчислен "; }

                        Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                        a = int.Parse(Console.ReadLine());
                         if (a == 1)
                        {
                            fakultet = "фкб";
                            first_grade OneF = new first_grade (name, lastname, group, status, fakultet);
                            Console.WriteLine(b1 + ". ");
                            OneF.Display();
                            list1.Add(OneF.Name + " " + OneF.LastName + " " + OneF.Group + " " + OneF.Status + " " + OneF.Fakultet);

                        }
                        else if (a == 2)
                        {
                            fakultet = "разработка ";
                            first_grade OneR = new first_grade(name, lastname, group, status, fakultet);
                            Console.WriteLine(b1 + ". ");
                            OneR.Display();
                            list1.Add(OneR.Name + " " + OneR.LastName + " " + OneR.Group + " " + OneR.Status + " " + OneR.Fakultet);
                        }
                    }
                    //else if (a == 2)
                    //{
                    //    b2++;
                    //    Console.WriteLine("введите имя студента");
                    //    name = Console.ReadLine();
                    //    Console.WriteLine("введите фамилию студента");
                    //    lastname = Console.ReadLine();
                    //    Console.WriteLine("введите группу студента: 1 или 2");
                    //    group = int.Parse(Console.ReadLine());
                    //    while ((group != 1) && (group != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                    //        group = int.Parse(Console.ReadLine());
                    //    }
                    //    Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                    //    sstatus = int.Parse(Console.ReadLine());
                    //    while ((sstatus != 1) && (sstatus != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                    //        sstatus = int.Parse(Console.ReadLine());
                    //    }
                    //    if (sstatus == 1) { status = "учится "; }
                    //    else { expelled2++; status = "отчислен "; }
                    //    Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                    //    a = int.Parse(Console.ReadLine());
                    //    while ((a != 1) && (a != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                    //        a = int.Parse(Console.ReadLine());
                    //    }
                    //    if (a == 1)
                    //    {
                    //        fakultet = "фкб";
                    //        fkb2 TwoF = new fkb2(name, lastname, group, status, fakultet);
                    //        TwoF.Display();
                    //        list2.Add(TwoF);
                    //        TwoF.Display();
                    //    }
                    //    else if (a == 2)
                    //    {
                    //        fakultet = "разработка ";
                    //        raz2 TwoR = new raz2(name, lastname, group, status, fakultet);
                    //        TwoR.Display();
                    //        list2.Add(TwoR);
                    //        TwoR.Display();
                    //    }
                    //}
                    //else if (a == 3)
                    //{
                    //    b3++;
                    //    Console.WriteLine("введите имя студента");
                    //    name = Console.ReadLine();
                    //    Console.WriteLine("введите фамилию студента");
                    //    lastname = Console.ReadLine();
                    //    Console.WriteLine("введите группу студента: 1 или 2");
                    //    group = int.Parse(Console.ReadLine());
                    //    while ((group != 1) && (group != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                    //        group = int.Parse(Console.ReadLine());
                    //    }
                    //    Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                    //    sstatus = int.Parse(Console.ReadLine());
                    //    while ((sstatus != 1) && (sstatus != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                    //        sstatus = int.Parse(Console.ReadLine());
                    //    }
                    //    if (sstatus == 1) { status = "учится "; }
                    //    else { expelled3++; status = "отчислен "; }

                    //    Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                    //    a = int.Parse(Console.ReadLine());
                    //    while ((a != 1) && (a != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                    //        a = int.Parse(Console.ReadLine());
                    //    } while ((group != 1) && (group != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                    //        group = int.Parse(Console.ReadLine());
                    //    }
                    //    Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                    //    sstatus = int.Parse(Console.ReadLine());
                    //    while ((sstatus != 1) && (sstatus != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                    //        sstatus = int.Parse(Console.ReadLine());
                    //    }
                    //    if (sstatus == 1) { status = "учится "; }
                    //    else { expelled3++; status = "отчислен "; }

                    //    Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                    //    a = int.Parse(Console.ReadLine());
                    //    while ((a != 1) && (a != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                    //        a = int.Parse(Console.ReadLine());
                    //    }
                    //    if (a == 1)
                    //    {
                    //        fakultet = "фкб";
                    //        fkb3 ThreeF = new fkb3(name, lastname, group, status, fakultet);
                    //        ThreeF.Display();
                    //        list3.Add(ThreeF);
                    //    }
                    //    else if (a == 2)
                    //    {
                    //        fakultet = "разработка ";
                    //        raz3 ThreeR = new raz3(name, lastname, group, status, fakultet);
                    //        ThreeR.Display();
                    //        list3.Add(ThreeR);
                    //    }
                    //}
                    //else if (a == 4)
                    //{
                    //    b4++;
                    //    Console.WriteLine("введите имя студента");
                    //    name = Console.ReadLine();
                    //    Console.WriteLine("введите фамилию студента");
                    //    lastname = Console.ReadLine();
                    //    Console.WriteLine("введите группу студента: 1 или 2");
                    //    group = int.Parse(Console.ReadLine());
                    //    while ((group != 1) && (group != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                    //        group = int.Parse(Console.ReadLine());
                    //    }
                    //    Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                    //    sstatus = int.Parse(Console.ReadLine());
                    //    while ((sstatus != 1) && (sstatus != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                    //        sstatus = int.Parse(Console.ReadLine());
                    //    }
                    //    if (sstatus == 1) { status = "учится "; }
                    //    else { expelled4++; status = "отчислен "; }

                    //    Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                    //    a = int.Parse(Console.ReadLine());
                    //    while ((a != 1) && (a != 2))
                    //    {
                    //        Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                    //        a = int.Parse(Console.ReadLine());
                    //    }
                    //    if (a == 1)
                    //    {
                    //        fakultet = "фкб";
                    //        fkb4 FourF = new fkb4(name, lastname, group, status, fakultet);
                    //        FourF.Display();
                    //        list4.Add(FourF);
                    //    }
                    //    else if (a == 2)
                    //    {
                    //        fakultet = "разработка ";
                    //        raz4 FourR = new raz4(name, lastname, group, status, fakultet);
                    //        FourR.Display();
                    //        list4.Add(FourR);
                    //    }
                    //}
                    Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
                    k = int.Parse(Console.ReadLine());
                }
                else if (k == 2)
                {
                    int m;
                    Console.WriteLine("С какого курса удалить? 1,2,3,4");
                    a = int.Parse(Console.ReadLine());
                    while ((a != 1) && (a != 2) && (a != 3) && (a != 4))
                    {
                        Console.WriteLine("Недопустимое значение, выберите 1 или 2 или 3 или 4");
                        a = int.Parse(Console.ReadLine());

                    }
                    if (a == 1)
                    {
                        for (int i = 0; i < list1.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {list1[i]}");
                        }
                        Console.WriteLine("Какую запись удалить? Если нужно удалить все, нажмите 0 ");
                        m = int.Parse(Console.ReadLine());
                        if (m == 0)
                        {
                            list1.Clear();
                        }
                        else
                        {
                            list1.RemoveAt(m - 1);
                        }
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("Какую запись удалить? Если нужно удалить все, нажмите 0 ");
                        m = int.Parse(Console.ReadLine());
                        if (m == 0)
                        {
                            list2.Clear();
                            b2 = 0;
                        }
                        else
                        {
                            list2.RemoveAt(m - 1);
                            b2 = b2 - 1;
                        }
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("Какую запись удалить? Если нужно удалить все, нажмите 0 ");
                        m = int.Parse(Console.ReadLine());
                        if (m == 0)
                        {
                            list3.Clear();
                            b3 = 0;
                        }
                        else
                        {
                            list3.RemoveAt(m - 1);
                            b3 = b3 - 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Какую запись удалить? Если нужно удалить все, нажмите 0 ");
                        m = int.Parse(Console.ReadLine());
                        if (m == 0)
                        {
                            list4.Clear();
                            b4 = 0;
                        }
                        else
                        {
                            list4.RemoveAt(m - 1);
                            b4 = b4 - 1;
                        }
                    }
                    Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
                    k = int.Parse(Console.ReadLine());
                }
                //else if (k == 3)
                //{
                //    int t;
                //    Console.WriteLine("на каком курсе изменить запись?");
                //    t = int.Parse(Console.ReadLine());
                //    if (t == 1) 
                //    {
                //    Console.WriteLine("какую запись изменить? Введите номер записи ");
                //    t = int.Parse(Console.ReadLine());
                //        Console.WriteLine("введите имя студента");
                //        name = Console.ReadLine();
                //        Console.WriteLine("введите фамилию студента");
                //        lastname = Console.ReadLine();
                //        Console.WriteLine("введите группу студента: 1 или 2");
                //        group = int.Parse(Console.ReadLine());
                //        while ((group != 1) && (group != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                //            group = int.Parse(Console.ReadLine());
                //        }
                //        Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                //        sstatus = int.Parse(Console.ReadLine());
                //        while ((sstatus != 1) && (sstatus != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                //            sstatus = int.Parse(Console.ReadLine());
                //        }
                //        if (sstatus == 1) { status = "учится "; }
                //        else { status = "отчислен "; }

                //        Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                //        a = int.Parse(Console.ReadLine());
                //        while ((a != 1) && (a != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                //            a = int.Parse(Console.ReadLine());
                //        }
                //        if (a == 1)
                //        {
                //            fakultet = "фкб";
                //            fkb1 OneF = new fkb1(name, lastname, group, status, fakultet);
                //            OneF.Display();
                //            list1[t-1] = OneF;

                //        }
                //        else if (a == 2)
                //        {
                //            fakultet = "разработка ";
                //            raz1 OneR = new raz1(name, lastname, group, status, fakultet);
                //            OneR.Display();
                //            list1[t-1] = OneR;
                //        }
                //     }
                //    else if (t == 2)
                //    {
                //        Console.WriteLine("какую запись изменить? Введите номер записи ");
                //        t = int.Parse(Console.ReadLine());
                //        Console.WriteLine("введите имя студента");
                //        name = Console.ReadLine();
                //        Console.WriteLine("введите фамилию студента");
                //        lastname = Console.ReadLine();
                //        Console.WriteLine("введите группу студента: 1 или 2");
                //        group = int.Parse(Console.ReadLine());
                //        while ((group != 1) && (group != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                //            group = int.Parse(Console.ReadLine());
                //        }
                //        Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                //        sstatus = int.Parse(Console.ReadLine());
                //        while ((sstatus != 1) && (sstatus != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                //            sstatus = int.Parse(Console.ReadLine());
                //        }
                //        if (sstatus == 1) { status = "учится "; }
                //        else { status = "отчислен "; }

                //        Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                //        a = int.Parse(Console.ReadLine());
                //        while ((a != 1) && (a != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                //            a = int.Parse(Console.ReadLine());
                //        }
                //        if (a == 1)
                //        {
                //            fakultet = "фкб";
                //            fkb2 TwoF = new fkb2(name, lastname, group, status, fakultet);
                //            TwoF.Display();
                //            list2[t - 1] = TwoF;

                //        }
                //        else if (a == 2)
                //        {
                //            fakultet = "разработка ";
                //            raz2 TwoR = new raz2(name, lastname, group, status, fakultet);
                //            TwoR.Display();
                //            list2[t - 1] = TwoR;
                //        }
                //    }
                //    else if (t == 3)
                //    {
                //        Console.WriteLine("какую запись изменить? Введите номер записи ");
                //        t = int.Parse(Console.ReadLine());
                //        Console.WriteLine("введите имя студента");
                //        name = Console.ReadLine();
                //        Console.WriteLine("введите фамилию студента");
                //        lastname = Console.ReadLine();
                //        Console.WriteLine("введите группу студента: 1 или 2");
                //        group = int.Parse(Console.ReadLine());
                //        while ((group != 1) && (group != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                //            group = int.Parse(Console.ReadLine());
                //        }
                //        Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                //        sstatus = int.Parse(Console.ReadLine());
                //        while ((sstatus != 1) && (sstatus != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                //            sstatus = int.Parse(Console.ReadLine());
                //        }
                //        if (sstatus == 1) { status = "учится "; }
                //        else { status = "отчислен "; }

                //        Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                //        a = int.Parse(Console.ReadLine());
                //        while ((a != 1) && (a != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                //            a = int.Parse(Console.ReadLine());
                //        }
                //        if (a == 1)
                //        {
                //            fakultet = "фкб";
                //            fkb3 ThreeF = new fkb3(name, lastname, group, status, fakultet);
                //            ThreeF.Display();
                //            list3[t - 1] = ThreeF;

                //        }
                //        else if (a == 2)
                //        {
                //            fakultet = "разработка ";
                //            raz3 ThreeR = new raz3(name, lastname, group, status, fakultet);
                //            ThreeR.Display();
                //            list3[t - 1] = ThreeR;
                //        }
                //    }
                //    else 
                //    {
                //        Console.WriteLine("какую запись изменить? Введите номер записи ");
                //        t = int.Parse(Console.ReadLine());
                //        Console.WriteLine("введите имя студента");
                //        name = Console.ReadLine();
                //        Console.WriteLine("введите фамилию студента");
                //        lastname = Console.ReadLine();
                //        Console.WriteLine("введите группу студента: 1 или 2");
                //        group = int.Parse(Console.ReadLine());
                //        while ((group != 1) && (group != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 или 2");
                //            group = int.Parse(Console.ReadLine());
                //        }
                //        Console.WriteLine("введите статус студента: 1 - учится, 2 - отчислен");
                //        sstatus = int.Parse(Console.ReadLine());
                //        while ((sstatus != 1) && (sstatus != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - учится, 2 - отчислен");
                //            sstatus = int.Parse(Console.ReadLine());
                //        }
                //        if (sstatus == 1) { status = "учится "; }
                //        else { status = "отчислен "; }

                //        Console.WriteLine("выберите факультет: 1 - фкб, 2 - разработка");
                //        a = int.Parse(Console.ReadLine());
                //        while ((a != 1) && (a != 2))
                //        {
                //            Console.WriteLine("Недопустимое значение, выберите 1 - фкб, 2 - разработка");
                //            a = int.Parse(Console.ReadLine());
                //        }
                //        if (a == 1)
                //        {
                //            fakultet = "фкб";
                //            fkb4 FourF = new fkb4(name, lastname, group, status, fakultet);
                //            FourF.Display();
                //            list4[t - 1] = FourF;

                //        }
                //        else if (a == 2)
                //        {
                //            fakultet = "разработка ";
                //            raz4 FourR = new raz4(name, lastname, group, status, fakultet);
                //            FourR.Display();
                //            list4[t - 1] = FourR;
                //        }
                //    }
                //    Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
                //    k = int.Parse(Console.ReadLine());
                //}

                else if (k == 4)
                {
                    int max_expelled1 = Math.Max(expelled1, expelled2);
                    int max_expelled2 = Math.Max(expelled3, expelled4);
                    int max_expelled = Math.Max(max_expelled1, max_expelled2);

                    if (max_expelled == max_expelled1)
                    {
                        if (max_expelled1 == expelled1)
                        {
                            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine("больше всего отчисленных на 1 курсе");
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine("больше всего отчисленных на 2 курсе");
                            }
                        }
                    }
                    else  
                    {
                        if (max_expelled2 == expelled3)
                        {
                            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine("больше всего отчисленных на 3 курсе");
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine("больше всего отчисленных на 4 курсе");
                            }
                        }
                    }
                    Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
                    k = int.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("какой курс вывести? 1, 2, 3 или 4 ");
                    a = int.Parse(Console.ReadLine());
                    while ((a != 1) && (a != 2) && (a != 3) && (a != 4))
                    {
                        Console.WriteLine("Недопустимое значение, выберите 1, 2, 3 или 4 ");
                        a = int.Parse(Console.ReadLine());
                    }
                    if (a == 1)
                    {
                     if (b1 == 0) Console.WriteLine("записей нет");
                        else
                        {
                            for (int i = 0; i < b1 - 1; i++)
                            {
                                Console.WriteLine(list1[i]);
                            }
                        }
                    }
                    else if (a == 2)
                    {
                        if (b2 == 0) Console.WriteLine("записей нет");
                        else
                        {
                            for (int i = 0; i < list2.Count-1; i++)
                            {
                                Console.WriteLine($"{i + 1}. {list2[i]}");
                            }
                        }
                    }
                    else if (a == 3)
                    {
                        if (b3 == 0) Console.WriteLine("записей нет");
                        else
                        {
                            for (int i = 0; i < list3.Count-1; i++)
                            {
                                Console.WriteLine($"{i + 1}. {list3[i]}");
                            }
                        }
                    }
                    else
                    {
                        if (b4 == 0) Console.WriteLine("записей нет");
                        else
                        {
                            for (int i = 0; i < list4.Count-1; i++)
                            {
                                Console.WriteLine($"{i + 1}. {list4[i]}");
                            }
                        }
                    }
                    Console.WriteLine("Выберите действие: 1(добавить запись), 2(удалить запись), 3(изменить запись), 4(записать результат в файл), 5(вывести данные о студентах ). Для выхода нажмите 7");
                    k = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}