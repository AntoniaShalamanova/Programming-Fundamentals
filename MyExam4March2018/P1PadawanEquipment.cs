using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabersCount = Math.Ceiling(studentsCount + (studentsCount * 0.1));
            int beltsCount = studentsCount - (studentsCount / 6);

            double totalEquipmentPrice = (lightsaberPrice * lightsabersCount) + (beltPrice * beltsCount) + (robePrice * studentsCount);

            if (totalEquipmentPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalEquipmentPrice - money:F2}lv more.");
            }
        }
    }
}
