﻿using System;

namespace ugeopgave3koe
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IVPDictionary dict = new HashingDictionary();
			dict.set("Hansen", 17);
			dict.set("Larsen", 21);
			Console.WriteLine("Hansen: " + dict.get("Hansen"));
			Console.WriteLine("Larsen: " + dict.get("Larsen"));
			Console.WriteLine("Contains Pedersen: " + dict.hasKey("Pedersen"));

			// check that the dictionary extends as it should
			for (int k = 0; k < 100; k++)
			{
				string mykey = "mykey" + k;
				dict.set(mykey, k * 10); // just some value
			}
			Console.WriteLine("mykey77 stores: " + dict.get("mykey77"));
		}
	}
}