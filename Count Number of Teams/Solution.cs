namespace Count_Number_of_Teams
{
    internal class Solution
    {
        private readonly int _teamSize = 3;
        private int IncreasingTeams(int[][] dp, int[] rating, int curIndex, int teamSize)
        {
            if (curIndex == rating.Length)
            {
                return 0;
            }

            if (teamSize == _teamSize)
            {
                return 1;
            }

            if (dp[curIndex][teamSize] != -1)
            {
                return dp[curIndex][teamSize];
            }

            int teamCount = 0;
            for (int nextIndex = curIndex + 1; nextIndex < rating.Length; ++nextIndex)
            {
                if (rating[curIndex] < rating[nextIndex])
                {
                    teamCount += IncreasingTeams(dp, rating, nextIndex, teamSize + 1);
                }
            }

            dp[curIndex][teamSize] = teamCount;
            return dp[curIndex][teamSize];
        }

        private int DecreasingTeams(int[][] dp, int[] rating, int curIndex, int teamSize)
        {
            if (curIndex == rating.Length)
            {
                return 0;
            }

            if (teamSize == _teamSize)
            {
                return 1;
            }

            if (dp[curIndex][teamSize] != -1)
            {
                return dp[curIndex][teamSize];
            }
            
            int teamCount = 0;
            for (int nextIndex = curIndex + 1; nextIndex < rating.Length; ++nextIndex)
            {
                if (rating[curIndex] > rating[nextIndex])
                {
                    teamCount += DecreasingTeams(dp, rating, nextIndex, teamSize + 1);
                }
            }

            dp[curIndex][teamSize] = teamCount;
            return dp[curIndex][teamSize];
        }

        public int NumTeams(int[] rating)
        {
            int[][] teamIncreasing = new int[rating.Length][];
            int[][] teamDecreasing = new int[rating.Length][];
            for (int i = 0; i < rating.Length; ++i)
            {
                teamIncreasing[i] = new int[_teamSize + 1];
                teamDecreasing[i] = new int[_teamSize + 1];
                //Array.Fill(teamIncreasing[i], -1);                
                //Array.Fill(teamDecreasing[i], -1);
                teamIncreasing[i][1] = 1;
                teamDecreasing[i][1] = 1;
            }

            int numTeams = 0;
            for (int teamSize = 2; teamSize <= _teamSize; ++teamSize)
            {
                for (int i = 0; i < rating.Length; ++i)
                {
                    for (int j = i + 1; j < rating.Length; ++j)
                    {
                        if (rating[i] < rating[j])
                        {
                            teamIncreasing[i][teamSize] += teamIncreasing[j][teamSize - 1];
                        }

                        if (rating[i] > rating[j])
                        {
                            teamDecreasing[i][teamSize] += teamDecreasing[j][teamSize - 1];
                        }
                    }
                }
            }
            //for (int index = 0; index < rating.Length; ++index)
            //{
            //    numTeams += IncreasingTeams(teamIncreasing, rating, index, 1) + DecreasingTeams(teamDecreasing, rating, index, 1);
            //}
            for (int i = 0; i < rating.Length; ++i)
            {
                numTeams += teamIncreasing[i][_teamSize] + teamDecreasing[i][_teamSize];
            }

            return numTeams;
        }
    }
}
