
        static void Main(string[] args)
        {
            int[,,] AMD = new int[10,10,10];
            int res = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        AMD [k, j, i]++;
                    }
                }
            }

        }