namespace helloWorld;

public class Variables
{
    static void Main()
    {
        // this is a variable on string type:
        string name = "Leonardo";
        // this is a variable on int type: 
        int number = 20;
        // this is a variable on float type:
        float floatNumber = 30.5f;
        // that variable needs a f on his final for be stable on a float type
        // this is a variable on double type
        double doubleNumber = 20.6;
        // that variable is the same thing of float type, but he has too much power on in use because her digits
        // this is a variable on decimal type
        decimal decimalNumber = 30.5m;
        // that variable can be used for money and needs to be finished with a m
        //this is a variable on bool type
        // that variables means true or false
        bool boolTrue = true;
        bool boolFalse = false;
        //this is a char 
        char a = 'a';
        // this is a string
        string stringfy = "Look a spell on you!";

        Console.WriteLine(stringfy);

        if (stringfy == "Look a spell on you") {
            Console.WriteLine("Dude, non-sense to change this is true.");
        } else {
            Console.WriteLine("WTF?");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        string[] names = { "Leonardo", "Lea", "Madeline" };
        Console.WriteLine(names[0]);

        foreach(string i in names)
        {
            Console.WriteLine(i);
        };


    }
}