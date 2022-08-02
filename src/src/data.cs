using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Data
    {
        private string _author;
        private string _content;
        private string _timestamp;
        public Data(string author, string content)
        {
            _author = author;
            _content = content;
            _timestamp = DateTime.Now.ToString();
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public string Timestamp
        {
            get { return _timestamp; }
        }
    }
}
