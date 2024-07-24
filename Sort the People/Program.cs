using Sort_the_People;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.SortPeople(["Mary", "John", "Emma"], [180, 165, 170])));
Console.WriteLine(string.Join(", ", solution.SortPeople(["Alice", "Bob", "Bob"], [155, 185, 150])));
