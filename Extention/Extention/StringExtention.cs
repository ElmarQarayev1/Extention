using System;
namespace Extention
{
	public static class StringExtention
	{
		public static bool IsContainsDigit(this string str)
		{
			if (String.IsNullOrWhiteSpace(str)) return false;

			for (int i = 0; i < str.Length; i++)
			{
				if (char.IsDigit(str[i]))
				{
					return true;
				}

			}
			return false;

		}

		public static string ToCapitalize(this string str)
		{

			if (String.IsNullOrWhiteSpace(str)) return str;

			return char.ToUpper(str[0]) + str.Substring(1).ToLower();

		}

		public static int[] GetValueIndexes(this string str,char c)
		{
           
                        int indexCount = 0;
                        for (int i = 0; i < str.Length; i++)
			{
				
				if (str[i] == c)
				{
				    indexCount++;
				}
			}

			int[] nums = new int[indexCount];

			int index = 0;

			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == c)
				{
					nums[index++] = i;
				}
			}
			return nums;
			
		}

		public static string GetFirstSentence(this string str)
		{
			if (String.IsNullOrWhiteSpace(str)) return str;

			return str.Substring(0, str.IndexOf('.'));

		}

		public static string GetSecondWord(this string str)
		{
			if (String.IsNullOrWhiteSpace(str)) return str;

			int startindex = str.IndexOf(' ')+1;
			int finalIndex = str.IndexOf(' ', str.IndexOf(' ') + 1);
			int length = finalIndex - startindex;

            return str.Substring(startindex,length);

		}

    }
}

