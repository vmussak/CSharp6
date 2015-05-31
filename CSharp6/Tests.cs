using CSharp6.Models;
using System;
using static System.DateTime;
using static System.Math;

namespace CSharp6 
{ 
    public static class Tests
    {
        public static void UsingStatic()
        {
            //Sem uso do using static
            var dataAtual = DateTime.Now;
            var raiz = Math.Pow(10, 3);

            //C#6 - usando using static
            var dataAtualUsingStatic = Now;
            var raizUsingStatic = Pow(10, 3);

            Console.WriteLine("Data atual sem using static: {0}", dataAtual);
            Console.WriteLine("Data atual com using static: {0}", dataAtualUsingStatic);
            Console.WriteLine("10^3 sem using static: {0}", raiz);
            Console.WriteLine("10^3 com using static: {0}", raizUsingStatic);
        }

        public static void UserInterpolation()
        {
            var user = new User(1, "José", "Geraldo", new DateTime(1980, 10, 15), 99999999999, "São Paulo", "SP");

            //Com string.Format
            var infoUser = string.Format("Nascimento: {0:dd/MM/yyyy}, CPF: {1:000-000-000-00}", user.Birth, user.Document);

            //Com interpolação de string
            var infoUserInterpolation = $"Nascimento: {user.Birth:dd/MM/yyyy}, CPF: {user.Document:000-000-000-00}";
        }

        public static void NullOperator()
        {
            var user = new User(1, "José", "Geraldo", new DateTime(1980, 10, 15), 99999999999, "São Paulo", "SP");
            var user2 = new User(1, "Maria", "das Dores", new DateTime(1950, 5, 21), 88888888888);

            //Sem o C#6
            var userCity = user.Address != null
                    ? user.Address.City
                    : "";

            var user2City = user2.Address != null
                    ? user2.Address.City
                    : "";

            //Com o C#6
            var userCity2 = user.Address?.City;
            var user2City2 = user2.Address?.City;


            Console.WriteLine("Sem C#6");
            Console.WriteLine("User 01 - {0}", userCity);
            Console.WriteLine("User 02 - {0}", user2City);

            Console.WriteLine();

            Console.WriteLine("Com C#6");
            Console.WriteLine("User 01 - {0}", userCity2);
            Console.WriteLine("User 02 - {0}", user2City2);
        }
    } 
} 





