using System;
namespace Extention
{
	public  static class IntExtention
	{
		public static bool IsOdd(this int num)
		{
			if (num % 2 != 0)
			{
				return true;
			}
			return false;
		}
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

    }
}

