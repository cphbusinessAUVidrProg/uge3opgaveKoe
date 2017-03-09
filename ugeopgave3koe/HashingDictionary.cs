using System;
namespace ugeopgave3koe
{
	public class HashingDictionary : IVPDictionary
	{
		public HashingDictionary()
		{
			size = 0; // 
			arr = new Pair[20];
		}

		Pair[] arr;
		int size;

		public bool hasKey(string key)
		{
			return arr[Find(key)] != null;
		}

		public bool isEmpty()
		{
			return size == 0;
		}

		public int Get (String key)
			{
				Pair res = arr[Find(key)];
				if (res != null)
					return res.Value;
				throw new IndexOutOfRangeException();
			}

		public void Set(String key, int val)
			{
			size++;
			if (size > arr.Length * 3 / 4)
				Extend();
			int here = Find(key);
			arr[here] = new Pair(key, val);
			}

		private int Find(string key)
		{
			int h = key.GetHashCode();
			int index = h % arr.Length;
			if (index < 0) index += arr.Length;
			while ( arr[index] != null && !arr[index].Key.Equals(key))
				index = (index + 1) % arr.Length;
			return index;
		}
		private void Extend()
		{
			int newLength = arr.Length * 3 / 2;
			Pair[] oldArray = arr;
			arr = new Pair[newLength];
			foreach (Pair p in oldArray)
			{
				if (p != null)
				{
					Set(p.Key, p.Value);
				}
			}
		}
	}
}
