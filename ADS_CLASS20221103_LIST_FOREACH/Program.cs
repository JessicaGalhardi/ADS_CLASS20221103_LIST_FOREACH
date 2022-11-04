class Program
{

    static void Main(string[] args)
    {
        try
        {
          List<double> lstNumbers = new List<double>();
            lstNumbers.Add(10.5);
            lstNumbers.Add(5.1);
            lstNumbers.Add(2.2);
            lstNumbers.Add(4.8);
            lstNumbers.Add(6.7);
            lstNumbers.Add(1.4);

            double bigValue = lstNumbers.Max();
            
            foreach (double x in lstNumbers)
            {

                Console.WriteLine("The value of lstNumbers(x) is: " + x);
                
            }

            Console.WriteLine("\n\rThe highest value of lstNumbers(x) is: " + lstNumbers.Max());
            Console.WriteLine("\n\rThe lowest value of lstNumbers(x) is: " + lstNumbers.Min());

            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while running the application" + ex);

        }
    }
}

