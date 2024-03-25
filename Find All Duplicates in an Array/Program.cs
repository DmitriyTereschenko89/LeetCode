using Find_All_Duplicates_in_an_Array;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<string> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] nums = Console.ReadLine().Trim().Split(' ');
	int[] arr = new int[nums.Length];
	for (int i = 0; i < nums.Length; i++)
	{
		arr[i] = int.Parse(nums[i]);
	}
	ans.Add(string.Join(", ", solution.FindDuplicates(arr)));
}
Console.WriteLine(string.Join("\n", ans));