using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = -4;
			A.Y = 3;
			//A.Print();
			Point B = new Point();
			B.X = 2;
			B.Y = -5;
			//Console.WriteLine(A.Distance(B));
			Point C = new Point();
			Console.WriteLine(Point.Distance(A, B));
		}
	}
}
