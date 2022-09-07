namespace Course
{
    class CourseClass
    {
        private int firstNumber = int.Parse(Console.ReadLine());
        private void Main()
        {
            VerifyNumber(this.firstNumber);
        }

        static void VerifyNumber (int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}