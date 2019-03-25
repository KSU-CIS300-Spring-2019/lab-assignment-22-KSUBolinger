using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        private bool _doesContain;
        private ITrie _onlyChild;
        private char _label;
        public ITrie Add(string s)
        {
            if(s == "")
            {
                _doesContain = true;
                return this;
            }
            else if()
        }

        public bool Contains(string s)
        {
            if(s == "")
            {
                return _doesContain;
            }
            return false;
        }

        public TrieWithOneChild(string s, bool isEmpty)
        {
           if(s == "" || s[0] > 'a' || s[0] < 'z')
            {
                throw new ArgumentException();
            }
            _doesContain = isEmpty;
            _label = s[0];
            _onlyChild = new TrieWithNoChildren().Add(s.Substring(1));
        } 
    }
}
