namespace Count_Sub_Islands
{
    internal class UnionFind
    {
        private readonly int[] parents;
        private readonly int[] sizes;

        public UnionFind(int n)
        {
            parents = new int[n];
            sizes = new int[n];
            for (int i = 0; i < n; ++i)
            {
                parents[i] = i;
                sizes[i] = 0;
            }
        }

        public int Find(int root)
        {
            while (root != parents[root])
            {
                root = parents[parents[root]];
            }

            return root;
        }

        public void Union(int x, int y)
        {
            int pX = Find(x);
            int pY = Find(y);
            if (pX == pY)
            {
                return;
            }

            if (sizes[pX] < sizes[pY])
            {
                parents[pX] = pY;
                sizes[pY] += sizes[pX];
            }
            else if (sizes[pX] > sizes[pY])
            {
                parents[pY] = pX;
                sizes[pX] += sizes[pY];
            }
            else
            {
                parents[pY] = pX;
                sizes[pX] += 1;
            }
        }
    }
}
