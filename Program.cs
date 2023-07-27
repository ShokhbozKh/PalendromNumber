namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //palendrom
            Console.Write("number: ");
            int number = int.Parse(Console.ReadLine());
            int startNumber = 0;
            int lastNumber;
            int orginalNumber = number;

            while (number > 0)
            {
                lastNumber = number % 10;

                startNumber = startNumber * 10 + lastNumber;// boshlanish
                //sonni oxirgi songa teng qilish kerak;

                number = number / 10;
                
            }
            if(orginalNumber == startNumber)
            {
                Console.WriteLine("Palindrom: " + orginalNumber);
            }
            else
            {
                Console.WriteLine("Palindrom emas: " + orginalNumber);
            }
        }
    }
}