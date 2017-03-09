using System;
namespace ugeopgave3koe
{
	interface IVPDictionary
	{// VP for videregående programmering
		bool isEmpty();
		bool hasKey(String key);
		int get(String key);
		void set(String key, int value);
	}
}
