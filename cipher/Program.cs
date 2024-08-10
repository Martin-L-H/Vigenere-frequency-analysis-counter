namespace cipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert unencrypted text");
            string word = Console.ReadLine();
            List<char> chars = word.ToList();
            List<char> chars2 = new List<char>();
            int[] array = new int[chars.Count-1];
            for (int i = 0; i < chars.Count(); i++)
            {
                chars2.Add(chars[i]);
            }
            for (int j = 0; j < chars.Count(); j++)
            {
                for (int i = chars.Count() - 1; i > -1; i--)
                {
                    if (i > 0)
                    {
                        chars2[i] = chars2[i - 1];
                    }
                    else
                    {
                        chars2[i] = '-';
                    }
                    if (chars[i] == chars2[i])
                    {
                        array[j]++;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i+1)+": "+array[i]);
            }
        }
    }
}