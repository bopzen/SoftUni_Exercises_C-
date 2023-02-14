namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randList = new RandomList();
            randList.Add("A");
            randList.Add("B");
            randList.Add("C");
            randList.Add("D");
            randList.Add("E");
            Console.WriteLine(randList.RandomString());
            Console.WriteLine(string.Join(" ", randList));
        }
    }
}