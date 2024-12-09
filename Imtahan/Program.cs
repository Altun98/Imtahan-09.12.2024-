using System.Text.RegularExpressions;

namespace Imtahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Misal1
            //Random rd = new Random();
            //int[] arr= new int[10];
            //int i = 0;
            //while (i < 10)
            //{
            //    arr[i] = rd.Next(1,99);
            //    i++;
            //}
            //int k = 0;
            //basla:
            //if (k<10)
            //{
            //    Console.WriteLine(arr[k]);
            //    k++;
            //    goto basla;
            //}

            #endregion

            #region Misal2
            //Console.Write("1-ci ededi daxil edin:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("2-ci ededi daxil edin:");
            //double b = double.Parse(Console.ReadLine());
            //double c = 0;
            //if (b != 0)
            //{
            //    c = (a / b) / 1000;
            //    Console.WriteLine(String.Format("{0:F3}",c));
            //}
            //else
            //{
            //    Console.WriteLine("0 -a bolmek olmaz ");
            //}
            #endregion
            #region Misal3
            //string cumle = "Men Azerbaycan ovladiyam";
            //Regex rx =new Regex(@"^Azerbaycan");
            //if (rx.IsMatch(cumle))
            //{
            //    Console.WriteLine("var");
            //}
            //else
            //{
            //    Console.WriteLine("yoxdur");
            //}          
            #endregion
            #region Misal4 
            //int[] arr = new int[12];
            //Random rd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rd.Next(1, 99);
            //}
            //Console.WriteLine("n ededini daxil edin");
            //int n = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % n == 0)
            //    {
            //        list.Add(i);
            //    }
            //}
            //int[] arrX = new int[list.Count];
            //arrX = list.ToArray();

            #endregion
            #region Misal5

            ////kxvadrat tenlik 
            //Console.Write("ardicil olaraq a,b,c -ni daxil edin:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //double x1, x2;
            ////diskirmanti hesablamaq
            //double d = (b * b) - 4 * (a * c);
            //if (d < 0)
            //{
            //    Console.WriteLine("tenliyin helli yoxdur");
            //}
            //else
            //{
            //    x1 = (-b - d) / 2 * a;
            //    x2 = (-b + d) / 2 * a;
            //    if (d == 0)
            //    {
            //        x1 = x2;
            //    }
            //}
            #endregion
            #region Misal7
            //int max = 0;
            //int MaxElement(params int[] arr)
            //{
            //    return arr.Max();
            //}
            //Console.WriteLine(MaxElement(12,34,56,7,23));         

            #endregion
            #region Misal12 
            //Random rd = new Random();
            //int n = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //List<int> list1 = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(rd.Next(1, 99));
            //}
            //for (int k = 0; k < 10; k++)
            //{
            //    if (list[k] % n == 0)
            //    {
            //        list1.Add(list[k]);
            //    }
            //}
            #endregion
            #region Misal14
            //string path = @"C:\Users\PC\Desktop\Ders\Sagird.txt";
            //Student sd1 = new Student()
            //{
            //    ID = 1,
            //    Name = "Abbas",
            //    Gebder = "kisi",
            //    Age = 14
            //};
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine(sd1.ID);
            //    sw.WriteLine(sd1.Name);
            //    sw.WriteLine(sd1.Gebder);
            //    sw.WriteLine(sd1.Age);
            //}
            #endregion

            #region Misal18
            //string path = @"C:\Users\PC\Desktop\Ders\Sagird.txt";
            //string path1 = @"C:\Users\PC\Desktop\Ders1\Sagird.txt";
            //if (File.Exists(path))
            //{
            //    File.Copy(path, path1, true);
            //}

            #endregion

            #region Misal16
            //IEnumerable<int> getNumber(int numer)
            //{
            //    for (int i = 0; i < numer; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            yield return i;
            //        }
            //    }

            //}

            //List<int> x = getNumber(17).ToList();
            //foreach (var item in x)
            //{
            //    Console.Write(item + ", ");
            //}
            #endregion

            #region Misal17
            // Kredit,Hesabat,Emeliyyat,Depozit
            //Queue<string> Kredit = new Queue<string>();
            //Kredit.Enqueue("Kredit almaq");
            //Kredit.Enqueue("Kredit Odenisi");
            //Kredit.Enqueue("Kretit melumat");
            //Kredit.Enqueue("Ipoteka krediti");

            //Console.WriteLine($"Novbeti sira{Kredit.Dequeue()} silinecek");
            //Console.WriteLine($"novbeti {Kredit.Peek()}");

            #endregion

            #region Misal_21
            //(int max, int min, int sum) GetArrayInfo(params int[] arrays)
            //{
            //    int _max = arrays.Max();
            //    int _min = arrays.Min();
            //    int _sum = arrays.Sum();
            //    return (_max, _min, _sum);
            //}
            //(int max, int min, int sum) result = GetArrayInfo(12, 34, 56, 78, 789);
            #endregion
            
        }
    }
}

