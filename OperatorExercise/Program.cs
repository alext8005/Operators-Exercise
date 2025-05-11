namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //excercise 1 basic operations
            int a = 9;
            int b = 7;

            int firstAddition = a + b;
            int secondSubstraction = a - b;
            int thirdMultiplication = a * b;
            int fourthDivision = a / b;
            int fifthModulus = a % b;

            Console.WriteLine($"{a}/{b} is {fourthDivision}, and the reminder is {fifthModulus} ");

            //Excersice 2 area of circle

            Console.WriteLine("Enter the radius of the circle");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);

            Console.WriteLine($"the area of a circle with a radius of {radius} is {area}");


        }

        public static double AreaOfCircle(double radius)

        {
            return Math.PI * Math.Pow(radius, 2);

        }
    }

}
    

