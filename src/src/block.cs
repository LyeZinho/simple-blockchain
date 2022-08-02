using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src;

namespace src
{
    public class Block
    {
        public int Hash;
        public int PreviousHash;
        public Data Data;

        public Block(string author, string content, int previousHash = 0)
        {
            this.Data = new Data(author, content);
            this.PreviousHash = previousHash;
            this.Hash = this.CalculateHash(this.Data, previousHash);
        }

        public int CalculateHash(Data data, int previousHash = 0)
        {
            string content = data.Author 
                + data.Content 
                + data.Timestamp
                + previousHash.ToString();
            return content.GetHashCode();
        }
    }
}
