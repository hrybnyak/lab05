
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] AMD = new int[1000];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        AMD[100*k+10*j+i]++;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Program time : {stopwatch.Elapsed}");
        }