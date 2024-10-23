using Spiral_Matrix_IV;

Solution solution = new();
ListNode head = new(3, new(0, new(2, new(6, new(8, new(1, new(7, new(9, new(4, new(2, new(5, new(5, new(0)))))))))))));
var ans = solution.SpiralMatrix(3, 5, head);
foreach(var item in ans)
{
    Console.WriteLine(string.Join(" ", item));
}
