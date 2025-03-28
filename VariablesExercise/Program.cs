namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "David";
            int age = 36;
            double avg = 98.7;
            decimal bankAccount = 1000000.00m;
            char initial = 'D';
            bool isMarried = true;
            
            Console.WriteLine($"Name: {myName}\nAge: {age}\nAverage: {avg}\nMoney: {bankAccount}\nInitial: {initial}\nMarried: {isMarried}");
            
        }
    }
}