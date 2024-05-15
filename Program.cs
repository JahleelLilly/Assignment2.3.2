namespace Assignment2._3._2
{
    //Tip Calculator 
    class TipCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter bill total: $");
            double billTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tip percentage:");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            double tipAmount = billTotal * (tipPercentage / 100);
            double grandTotal = billTotal + tipAmount;

            Console.WriteLine("Tip amount: {0:C}", tipAmount);
            //Displaying tip amount in currency format

            Console.WriteLine("Grandtotal (including tip): {0:C}", grandTotal);
            //Displaying grand total in currency format
            
        }
    }


}
