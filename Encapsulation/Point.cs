using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		//double x;
		//double y;
		//public double X
		//{
		//	get 
		//	{ 
		//		return x; 
		//	}
		//	set 
		//	{ 
		//		if(value > 200) value = 200;
		//		x = value; 
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 150) value = 150;
		//		y = value;
		//	}
		//}
		//public double GetX()
		//{
		//	return x; 
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x)
		//{
		//	if (x > 200) x = 200;
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	if (y > 150) y = 150;
		//	this.y = y;
		//}

		public double X { get; set; }
		public double Y { get; set; }
		public void Print()
		{
			//Console.WriteLine($"X = {GetX()}\t Y = {GetY()}");
			Console.WriteLine($"X = {X}\t Y = {Y}");			
		}

		public double Distance(Point other)
		{			
			return Math.Sqrt(Math.Pow((other.X - this.X), 2) + Math.Pow((other.Y - this.Y), 2));
		}
		public static double Distance(Point A, Point B)
		{			
			return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
		}
	}
}
