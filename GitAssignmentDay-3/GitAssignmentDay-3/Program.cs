class Program
{
    public static void Main(String[] Args)
    {
        Console.WriteLine("Welcome to Employee Wage Computation Program");
        int IS_PART_TIME = 1;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_PART_TIME)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");

        }
    }
}