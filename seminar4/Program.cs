namespace seminar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int target = 25;

            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var x = target - arr[i];
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        var j = x - arr[k];
                        if (set.Contains(j))
                        {
                            Console.WriteLine($"{arr[i]} + {j} + {arr[k]}");
                        }
                        else set.Add(arr[k]);
                    }
                }
                set.Clear();
            }

            Console.WriteLine("Done");
        }
    }
}