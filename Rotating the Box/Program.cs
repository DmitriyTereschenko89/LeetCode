using Rotating_the_Box;

Solution solution = new();
solution.RotateTheBox([['#', '.', '#']]);
Console.WriteLine(new string('-', 20));
solution.RotateTheBox([['#','.','*','.'],
              ['#','#','*','.']]);
Console.WriteLine(new string('-', 20));
solution.RotateTheBox([['#','#','*','.','*','.'],
              ['#','#','#','*','.','.'],
              ['#','#','#','.','#','.']]);
