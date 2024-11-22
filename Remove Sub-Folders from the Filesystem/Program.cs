using Remove_Sub_Folders_from_the_Filesystem;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.RemoveSubfolders(["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"])));
Console.WriteLine(string.Join(", ", solution.RemoveSubfolders(["/a", "/a/b/c", "/a/b/d"])));
Console.WriteLine(string.Join(", ", solution.RemoveSubfolders(["/a/b/c", "/a/b/ca", "/a/b/d"])));
