using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Language
{
    public class Member
    {
        public int Age { get; set; }
        public string Username { get; set; }
        public ulong UserId { get; set; }
    }

    internal class Core
    {
        public static Member[] Members = new Member[]
        {
            new Member
            {
                Age = 12,
                Username = "Syron"
            },
            new Member
            {
                Age = 15,
                Username = "Kyron"
            },
            new Member
            {
                Age = 15,
                Username = "Westie"
            },
            new Member
            {
                Age = 12,
                Username = "Fishy"
            },
            new Member
            {
                Age = 16,
                Username = "Monke"
            }
        };

        public static int PerferredAge = 13;

        public static void GroomChildren(Member Victim)
        {
            if (Victim.Age > 18)
                Console.WriteLine("  Cannot Groom Adults.");

            Console.WriteLine($"\n  Successfully Groomed {Victim.Username} They Lost Their Innocence At Age {Victim.Age}.");
        }

        public static void PostDickPicToMinor(Member Victim)
        {
            
        }

        public static void GetMinorsNude(Member Victim)
        {

        }

        public static string GetMinorsAddress(Member Victim)
        {
            if (Victim.Age > 18)
                return null;

            var Pick = new Random().Next(0, 5);
            switch (Pick)
            {
                case 1:
                    return "2389 Sussex Court.";
                case 2:
                    return "1936 Mahlon Street.";
                case 3:
                    return "946 Ingram Road.";
                case 4:
                    return "1690 Collins Avenue.";
                case 5:
                    return "1193 Byers Lane.";
            }
            return null;
        }

        public static bool FindNearbyPolice()
        {
            var Rnd = new Random().Next(0, 50);

            if (Rnd > 25)
                return false;

            return true;
        }

        public static void KickOverAge()
        {
            foreach (var Child in Members)
                if (Child.Age > 18)
                    Console.WriteLine($"  Made A False Report To The Police On {Child.Username}.");
        }

        public static void BreachUserInfo()
        {

        }

        public static void LogUsersData()
        {

        }

        public static bool BribePolice()
        {
            var Rnd = new Random().Next(0, 50);

            if (Rnd > 25)
                return false;

            return true;
        }

        public static Member[] GetChildren() => Members;

        public static int FindLocalPark()
        {
            return 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PedoSharp Console";
            Console.SetWindowSize(80, 20);

            if (Core.FindNearbyPolice() == true)
            {
                Console.WriteLine("\n  Police Nearby Attempting To Bribe Police.\n");

                if (Core.BribePolice() != true)
                {
                    Console.WriteLine("  Failed To Bribe Police You've Been Taken To Jail.\n");
                    Thread.Sleep(3000);
                    Process.GetCurrentProcess().Kill();
                }

                Console.WriteLine("  Successfully Bribed Police.\n");
                goto Begin;
            }

            Console.WriteLine("\n  No Police Nearby.\n");

            Begin:
            Core.FindLocalPark();
            Console.WriteLine("  Finding Local Park To Get Children.\n");

            var Result = Core.GetChildren();

            if (Result == null)
                Console.WriteLine("  No Underage Children Found.");

            Console.WriteLine("  Found Children.\n  -------------");
            foreach (var Child in Core.Members)
            {
                if (Child.Age > 18)
                    Console.WriteLine("\n  There Are Adults Here.");

                Console.WriteLine($"  Name -> {Child.Username} : Age -> {Child.Age}.");
            }

            var TotalChildren = Core.Members.Length;
            var Victim = Core.Members[new Random().Next(0, TotalChildren)];

            Console.WriteLine($"\n  Found {Victim.Username}'s Address : {Core.GetMinorsAddress(Victim)}");

            Core.GroomChildren(Victim);

            Console.ReadLine();
        }
    }
}
