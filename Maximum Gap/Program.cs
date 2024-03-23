using Maximum_Gap;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] nums = Console.ReadLine().Trim().Split(' ');
	int n = nums.Length;
	int[] arr = new int[n];
	for (int i = 0; i < n; i++)
	{
		arr[i] = int.Parse(nums[i]);
	}
	ans.Add(solution.MaximumGap(arr));
}
Console.WriteLine(string.Join("\n", ans));