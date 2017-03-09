using System;
namespace ugeopgave3koe
{
	public class SimpleDictionary :IVPDictionary
	{
		public SimpleDictionary()
		{
			top = -1; // 
			arr = new Pair[20];
		}

		Pair[] arr;
		int top;


		public bool hasKey(string key)
		{
			return find(key) >= 0;
		}

		public bool isEmpty()
		{
			return top < 0;
		}

		public int Get(string key)
		{
			int index = find(key);
			if (index >= 0) return arr[index].Value;
			throw new IndexOutOfRangeException();
		}

		public void Set(string key, int value)
		{
			if (top > arr.Length * 3 / 4) 
				extend();
			top++;
			arr[top] = new Pair(key, value);
		}

		private int find(string key)
		{
			for (int i = 0; i <= top; i++)
			{
				if (arr[i].Key.Equals(key))
					return i;
			}
			return -1;
		}

		private void extend()
		{
			int newLength = arr.Length * 3 / 2;
			Pair[] newArray = new Pair[newLength];
			Array.Copy(arr, newArray, top + 1);
			arr = newArray;
		}
	}

	class Pair
	{
		public Pair(string key, int value)
		{
			Key = key;
			Value = value;
		}

		public string Key { get; set; }
		public int Value { get; set; }
	}
}
