namespace PrimeSeiveTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum;
            Console.Write("Enter number to find all primes up to: ");
            maxNum = Convert.ToInt32(Console.ReadLine());
            List<int> PrimeNumbers = PrimeSeive(maxNum);

        }

        static List<int> PrimeSeive(int MaxNumber)
        {
            List<int> primes = new List<int>();
            bool[] numbers = new bool[MaxNumber+1];
            //Set all numbers in the array from 2 to MaxNumber to true
            // for i = 2, 3, 4, ..., not exceeding √n do
            // if A[i] is true
            //    for j = i2, i2 + i, i2 + 2i, i2 + 3i, ..., not exceeding n do
            //            set A[j] := false



            return primes;
        }
    }
}
