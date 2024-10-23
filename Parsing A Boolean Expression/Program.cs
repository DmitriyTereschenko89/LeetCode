using Parsing_A_Boolean_Expression;

Solution solution = new();
Console.WriteLine(solution.ParseBoolExpr("&(|(f))"));
Console.WriteLine(solution.ParseBoolExpr("|(f,f,f,t)"));
Console.WriteLine(solution.ParseBoolExpr("!(&(f,t))"));
