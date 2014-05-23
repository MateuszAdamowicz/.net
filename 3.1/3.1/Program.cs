using System;

namespace Application
{
	class Complex : IFormattable
	{
		public int real, imag;
		public Complex(int x, int y){
			real = x;
			imag = y;
		}
		public static Complex operator +(Complex x, Complex y){
			return new Complex (x.real + y.real, x.imag + y.imag);
		}
		public static Complex operator -(Complex x, Complex y){
			return new Complex (x.real - y.real, x.imag - y.imag);
		}
		public static Complex operator *(Complex x, Complex y){
			int tmp1 = x.real * y.real - x.imag * y.imag;
			int tmp2 = x.imag * y.real + x.real * y.imag;
			return new Complex (tmp1, tmp2);
		}
		public static Complex operator /(Complex x, Complex y){
			int tmp1 = x.real * y.real + x.imag * y.imag;
			int tmp2 = x.imag * y.real - x.real * y.imag;
			int tmp3 = x.imag^2 + y.imag^2;
			return new Complex (tmp1 / tmp3, tmp2 / tmp3);
		}
		public string ToString(string format, IFormatProvider fp){
			switch (format) {
			case "d" : 
				return real.ToString() + "+" + imag.ToString() + "i";
			case "w":
				return "[" + real.ToString () + "," + imag.ToString () + "]";
			default:
				return real.ToString() + "+" + imag.ToString() + "i";
			}
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Complex X = new Complex (2, 3);
			Complex Y = new Complex (5, 6);
			Complex Z = X + Y;
			Console.WriteLine (String.Format("{0:w}, {1:d}",X,Z));
		}
	}
}
