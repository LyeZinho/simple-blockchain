namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block genesis = new("satoshi", "sends 10btc to paul", 0);
            Console.WriteLine("genesis: "
                + " / " + genesis.Data.Author
                + " / " + genesis.Data.Content
                + " / " + genesis.Hash
                + " / " + genesis.PreviousHash
                );

            Block block1 = new("paul", "sends 1btc to satoshi", genesis.Hash);
            Console.WriteLine("block1: "
                + " / " + block1.Data.Author
                + " / " + block1.Data.Content
                + " / " + block1.Hash
                + " / " + block1.PreviousHash
                );

            Block block2 = new("sam", "sends 5btc to paul", block1.Hash);
            Console.WriteLine("block2: "
                + " / " + block2.Data.Author
                + " / " + block2.Data.Content
                + " / " + block2.Hash
                + " / " + block2.PreviousHash
                );
        }
    }
}