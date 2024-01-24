namespace Extention;

class Program
{
    static void Main(string[] args)
    {

        int a = 13;
        Console.WriteLine(a.IsOdd());

        Console.WriteLine(a.IsEven());

        string str = "SAlaM";

        Console.WriteLine(str.IsContainsDigit());

        Console.WriteLine(str.ToCapitalize());

        string str1 = "salam neterisen yaxsisanmi?";

        int[] nums = str1.GetValueIndexes('a');

        for (int i = 0; i < nums.Length; i++)
        {

            Console.WriteLine(nums[i]);

        }

        string sentence = "salam sagol neterisen. getdinmi bakiya dunen sabah bu gun. yaxsi oldu sagol.";

        Console.WriteLine(sentence.GetFirstSentence());

        string str2 = "salam menim adim elmardi";

        Console.WriteLine(str2.GetSecondWord());
     
        Console.ReadLine();
    }
}

