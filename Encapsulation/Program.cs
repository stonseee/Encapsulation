//#define DISTANCE
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
#if DISTANCE
			Point A = new Point();
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			A.X = 22;
			A.Y = 33;
			A.Print();

			//Point B = new Point();			
			Point B = new Point(A);
			B.Print();

			Point C;
			C = new Point(B);
			C.Print(); 
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Point D = new Point(A - B);
			D.Print();

			for (Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}
		}
	}
}
