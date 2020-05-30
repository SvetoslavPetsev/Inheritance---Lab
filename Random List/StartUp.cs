namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            RandomList rand = new RandomList();
            rand.AddRange(new List<string> { "pesho", "ivan", "joro" });
            Console.WriteLine(rand.RandomString());
        }
    }
}
