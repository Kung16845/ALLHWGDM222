using System;

class Program
{
    static void Main(string[] args)
    {
          // รับค่าพิกัดจากผู้ใช้
            Console.WriteLine("Enter the coordinates of the center of the first circle:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the center of the second circle:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the first circle:");
            double r1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the second circle:");
            double r2 = double.Parse(Console.ReadLine());

            // คำนวณหาพิกัดของจุดตัด
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double a = (r1 * r1 - r2 * r2 + d * d) / (2 * d);
            double h = Math.Sqrt(r1 * r1 - a * a);
            double x3 = x1 + a * (x2 - x1) / d;
            double y3 = y1 + a * (y2 - y1) / d;
            double x4 = x3 + h * (y2 - y1) / d;
            double y4 = y3 - h * (x2 - x1) / d;
            double x5 = x3 - h * (y2 - y1) / d;
            double y5 = y3 + h * (x2 - x1) / d;

            // แสดงผลลัพธ์
            Console.WriteLine("The intersection points of the circles are:");
            
            Console.WriteLine("({0}, {1})", x5, y5);
            Console.WriteLine("({0}, {1})", x4, y4);
    }
}