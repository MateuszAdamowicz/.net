using System;
using System.Collections;

namespace Application
{
	class Set: ArrayList{
		public override int Add (object value)
		{
			if (this.IndexOf(value) >= 0)
				return -1;
			else {
				return base.Add (value);
			}
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Set array = new Set ();
			array.Add (1);
			array.Add (2);
			array.Add ("siedem");
			array.Add (1);
			array.Add ("siedem");
			array.Add (3);
			foreach (var x in array) {
				Console.WriteLine (x);
			}
		}
	}
}
