namespace MinimumLengthStringAfterDeletingSimilarEnds
{
	public class Solution
	{
		public int MinimumLength(string s)
		{
			int l = 0;
			int r = s.Length - 1;
			while (l <= r)
			{
				if (s[l] == s[r])
				{
					char letter = s[l];
					while (l <= r && s[l] == letter)
					{
						++l;
					}
					while (l <= r && s[r] == letter)
					{
						--r;
					}
				}
				else
				{
					break;
				}
				
			}
			return r - l + 1;
		}
	}
}