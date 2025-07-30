namespace Program
{
    public class ExceptionsP
    {
        public ExceptionsP()
        {
            try
            {
                int[] nums = [1, 2, 4];
                Console.WriteLine(nums[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The try-catch is finished.");
            }

        }
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old!");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        
    }
}