using System.Text;

namespace Custon_Sort_String
{
	public class Solution
	{
		public string CustomSortString(string order, string s)
		{
			Dictionary<char, int> mapOrder = [];
			for (int i = 0; i < order.Length; ++i)
			{
				mapOrder[order[i]] = i;
			}
			int n = s.Length;
			List<char>[] bucket = new List<char>[n];
			for (int i = 0; i < n; ++i)
			{
				bucket[i] = [];
			}
			for (int i = 0; i < n; ++i)
			{
				if (mapOrder.TryGetValue(s[i], out int index))
				{
					bucket[index].Add(s[i]);
				}
				else
				{
					bucket[n - 1].Add(s[i]);
				}
			}
			StringBuilder answer = new();
			foreach (var chars in bucket)
			{
				answer.Append(new string(chars.ToArray()));
			}
			return answer.ToString();
		}
	}
}
