using DetectCapitalString;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("# 520. Detect Capital\r\n\r\n" +
            "We define the usage of capitals in a word to be right when one of the following cases holds:\r\n\r\n" +
            "**1- All letters in this word are capitals, like \"USA\".**\r\n" +
            "**2- All letters in this word are not capitals, like \"leetcode\".**\r\n" +
            "**3- Only the first letter in this word is capital, like \"Google\".**\r\n");

        Console.WriteLine("Test Case:\r\n");
        
        Console.WriteLine($"USA: {DetectCapital.DetectCapitalUse("USA")}");
        Console.WriteLine($"leetcode: {DetectCapital.DetectCapitalUse("leetcode")}");
        Console.WriteLine($"Google: {DetectCapital.DetectCapitalUse("Google")}");
        Console.WriteLine($"FlaG: {DetectCapital.DetectCapitalUse("FlaG")}");
    }
}