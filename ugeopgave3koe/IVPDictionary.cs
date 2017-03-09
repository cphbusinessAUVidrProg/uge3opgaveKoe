using System;
namespace ugeopgave3koe
{
	interface IVPDictionary
	{// VP for videregående programmering
		bool isEmpty();
		bool hasKey(String key);
			
		int Get(String key);
		void Set(String key, int value);
	}
}
