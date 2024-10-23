using Kth_Largest_Element_in_a_Stream;

KthLargest kthLargest = new(3, [4, 5, 8, 2]);
Console.WriteLine(kthLargest.Add(3));   // return 4
Console.WriteLine(kthLargest.Add(5));   // return 5
Console.WriteLine(kthLargest.Add(10));  // return 5
Console.WriteLine(kthLargest.Add(9));   // return 8
Console.WriteLine(kthLargest.Add(4));   // return 8
