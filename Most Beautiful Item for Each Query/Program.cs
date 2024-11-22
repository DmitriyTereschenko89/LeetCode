using Most_Beautiful_Item_for_Each_Query;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.MaximumBeauty([[1, 2], [3, 2], [2, 4], [5, 6], [3, 5]], [1, 2, 3, 4, 5, 6])));
Console.WriteLine(string.Join(", ", solution.MaximumBeauty([[1, 2], [1, 2], [1, 3], [1, 4]], [1])));
Console.WriteLine(string.Join(", ", solution.MaximumBeauty([[10, 1000]], [5])));
Console.WriteLine(string.Join(", ", solution.MaximumBeauty([[193, 732], [781, 962], [864, 954], [749, 627], [136, 746], [478, 548], [640, 908], [210, 799], [567, 715], [914, 388], [487, 853], [533, 554], [247, 919], [958, 150], [193, 523], [176, 656], [395, 469], [763, 821], [542, 946], [701, 676]], [885, 1445, 1580, 1309, 205, 1788, 1214, 1404, 572, 1170, 989, 265, 153, 151, 1479, 1180, 875, 276, 1584])));
