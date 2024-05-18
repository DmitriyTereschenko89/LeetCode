namespace OpenTheLock
{
	public class Solution
	{
		private readonly Dictionary<char, char> nextDigit = new()
		{
			['0'] = '1',
			['1'] = '2',
			['2'] = '3',
			['3'] = '4',
			['4'] = '5',
			['5'] = '6',
			['6'] = '7',
			['7'] = '8',
			['8'] = '9',
			['9'] = '0'
		};
		private readonly Dictionary<char, char> prevDigit = new()
		{
			['0'] = '9',
			['1'] = '0',
			['2'] = '1',
			['3'] = '2',
			['4'] = '3',
			['5'] = '4',
			['6'] = '5',
			['7'] = '6',
			['8'] = '7',
			['9'] = '8'
		};

		public int OpenLock(string[] deadends, string target)
		{
			if (target == "0000")
			{
				return 0;
			}
			HashSet<string> trapedCombos = new(deadends);
			Dictionary<string, int> steps = [];
			Queue<string> queue = [];
			steps.Add("0000", 0);
			queue.Enqueue("0000");
			while (queue.Count > 0)
			{
				string top = queue.Dequeue();
				if (trapedCombos.Contains(top))
				{
					continue;
				}
				for (int i = 0; i < 4; ++i)
				{
					string newCombo = top[..i] + nextDigit[top[i]] + top[(i + 1)..];
					if (!trapedCombos.Contains(newCombo) && !steps.ContainsKey(newCombo))
					{
						steps.Add(newCombo, steps[top] + 1);
						queue.Enqueue(newCombo);
						if (newCombo == target)
						{
							return steps[newCombo];
						}
					}
					newCombo = top[..i] + prevDigit[top[i]] + top[(i + 1)..];
					if (!trapedCombos.Contains(newCombo) && !steps.ContainsKey(newCombo))
					{
						steps.Add(newCombo, steps[top] + 1);
						queue.Enqueue(newCombo);
						if (newCombo == target)
						{
							return steps[newCombo];
						}
					}
				}
			}
			return -1;
		}
	}
}
