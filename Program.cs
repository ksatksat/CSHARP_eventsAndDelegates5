using System;
using static System.Console;
class Program{
    static void Main(string[] args){
        Action<string> agree = text => WriteLine(text + " It is Correct!");
        agree("Elephants are able to fly!");
        Action disagree = () => WriteLine("Completely nonsense!");
        disagree();

        Func<int,int,int> substract = (a,b) => a-b;
        Func<string,int> parseToInt = (s) =>
        {
            int parsedInt = 0;
            try
            {
                parsedInt = Convert.ToInt32(s);
                return parsedInt;
            } catch(Exception ex)
            {
                WriteLine(ex);
            }
            return 0;
        };
        WriteLine(substract(78,38));
        int res = parseToInt("756");
        WriteLine(res == 0 ? "Failed!" : $"Successfully parsed to int: {res}");

        Predicate<string> isFemale = str => str.ToLower().Trim() == "female";
        Predicate<int> isTripleSeven = num => num == 777;
        WriteLine(isFemale("Male"));
        WriteLine(isFemale(" Female "));
        WriteLine(isTripleSeven(777));
    }
}