using System;
using System.Collections.Generic;

namespace trie
{
        
            public class TrieNode
        {
            public Dictionary<char, TrieNode> children;
            public bool isEndOfWord;

            public TrieNode()
            {
                children = new Dictionary<char, TrieNode>();
                isEndOfWord = false;
            }
        }

        public class Trie
        {
            private TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word)
            {
                TrieNode current = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    if (!current.children.ContainsKey(c))
                    {
                        current.children[c] = new TrieNode();
                    }
                    current = current.children[c];
                }
                current.isEndOfWord = true;
            }

            public bool Search(string word)
            {
                TrieNode current = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    if (!current.children.ContainsKey(c))
                    {
                        return false;
                    }
                    current = current.children[c];
                }
                return current.isEndOfWord;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Trie trie = new Trie();

                trie.Insert("дом");
                trie.Insert("дочь");
                trie.Insert("день");
                trie.Insert("кот");
                trie.Insert("код");
                trie.Insert("кора");

                Console.WriteLine(trie.Search("дом")); 
                Console.WriteLine(trie.Search("дерево")); 
                Console.WriteLine(trie.Search("котенок")); 
                Console.WriteLine(trie.Search("кор")); 
                Console.WriteLine(trie.Search("кора")); 
                Console.WriteLine(trie.Search("ребро")); 
            }
        }
    
    
}
