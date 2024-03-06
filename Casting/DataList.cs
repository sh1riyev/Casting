using System;
namespace Casting
{
	public class DataList
	{
		public string[] Datas = new string[10];
		public string this[int index]
		{
			get
			{
				return Datas[index];
			}
			set
			{
				Datas[index] = value;
			}
		}
	}
}

