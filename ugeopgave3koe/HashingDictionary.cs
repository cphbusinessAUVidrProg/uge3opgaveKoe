using System;
namespace ugeopgave3koe
{
	public class HashingDictionary :IVPDictionary
	{
		public HashingDictionary(){
			size = 0; // 
			arr = new Pair[20];
		}

		Pair[] arr;
		int size;

		public bool hasKey(string key)
		{
			return arr[find(key)] != null;
		}

		public bool isEmpty()
		{
			return size > 0;
		}

		public int get(string key)
		{
			Pair res = arr[find(key)];
			if (res != null)
				return res.Value;
			throw new IndexOutOfRangeException();
		}

		public void set(string key, int value)
		{
			size++;
			if (size > arr.Length * 3 / 4)
				extend();
			int here = find(key);
			arr[here] = new Pair(key, value);
		}

		private int find(string key)
		{
			int h = key.GetHashCode();
			int index = h % arr.Length;
			if (index < 0) index += arr.Length;
			while ( arr[index] != null && !arr[index].Key.Equals(key))
				index = (index + 1) % arr.Length;
			return index;
		}

		private void extend()
		{
			int newLength = arr.Length * 3 / 2;
			Pair[] oldArray = arr;
			arr = new Pair[newLength];
			for (int oldIndex = 0; oldIndex < oldArray.Length; oldIndex++)
			{
				Pair p = oldArray[oldIndex];
				if (p != null)
				{
					set(p.Key, p.Value);
				}
			}
		}
	}
}
