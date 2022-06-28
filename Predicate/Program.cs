using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = {
                                new Point(5, 5),
                                new Point(5, 4),
                                new Point(5, 3),
                                new Point(7, 6),
                                new Point(9, 4)
                             };

            Predicate<Point> predicate = FindPoints;
            Point first = Array.Find(points, predicate);

            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

            //char[] arr = { 'p','q','r'};
            //string s = new string(arr);
            //Console.WriteLine(s);

            Console.ReadKey();
        }

        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 26;
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }        
    }
}
