namespace Remove_Sub_Folders_from_the_Filesystem
{
    using System;
    using System.Collections.Generic;

    internal class Solution
    {
        private class TrieNode
        {
            public readonly Dictionary<string, TrieNode> children = [];
            public string word = null;
        }

        private class Trie
        {
            private readonly TrieNode root = new();

            public void Push(string path)
            {
                TrieNode node = root;
                string[] folders = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
                foreach (string folder in folders)
                {
                    if (!node.children.ContainsKey(folder))
                    {
                        node.children.Add(folder, new TrieNode());
                    }

                    node = node.children[folder];
                }

                node.word = path;
            }

            private void Folders(List<string> paths, TrieNode root)
            {
                foreach (var pair in root.children)
                {
                    if (pair.Value.word is null)
                    {
                        Folders(paths, pair.Value);
                    }
                    else
                    {
                        paths.Add(pair.Value.word);
                    }
                }
            }

            public void Folders(List<string> paths)
            {
                TrieNode node = root;
                Folders(paths, node);
            }
        }

        public IList<string> RemoveSubfolders(string[] folder)
        {
            Trie trie = new();
            foreach (string path in folder)
            {
                trie.Push(path);
            }

            List<string> folders = [];
            trie.Folders(folders);
            return folders;
        }
    }
}
