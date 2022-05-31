using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Student classınız olsun, hər dəfə classdan yeni obyekt yarananda, studentin age - i əvvəlki son yaranan studentin yaşından 1 çox olsun. Məsələn:

            //            Student tamerlan = new Student();
            //            Console.WriteLine(tamerlan.Age); ://1

            //            Student faiq = new Student();
            //            Console.WriteLine(faiq.Age); ://2

            //            Student tural = new Student();
            //            Console.WriteLine(tural.Age); ://3

            //            Student emil = new Student();
            //            Console.WriteLine(emil.Age); ://4

 //Not: loop falan istifade etmək olmaz; yuxarıdakı kodu main methoduna paste edib icra edəndə, komentlərdə yazılan nəticələr çap olunmalıdı
            //1
            //2
            //3
            //4

            Student tural = new Student();
            Console.WriteLine(tural.Age);

            Student emil = new Student();
            Console.WriteLine(emil.Age);
            Student tamerlan = new Student();
            Console.WriteLine(tamerlan.Age);
            Student faiq = new Student();
            Console.WriteLine(faiq.Age);


           


        }
    }
}
