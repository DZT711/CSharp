string a="abcdefgjklmnopqrstuvwxyz";
Console.WriteLine(a.Length);
Console.WriteLine(a.ToUpper());
Console.WriteLine(a.ToLower());

string str1="abc";
string str2="abc";
Console.WriteLine(str1 == str2);

string s1 = "Nguyen";
string s2 = " Huy";
Console.WriteLine(string.Concat(s1, s2));

//String Interpolation
string substr1 = "Dad";
string substr2 = "Mom";
Console.WriteLine($"My family have {substr1} & {substr2} ");


string c = "Hello C#";
Console.WriteLine(c[0]);
int d = c.IndexOf("C");//tra ve vi tri chu C trong chuoi c
Console.WriteLine(d);
Console.WriteLine(c.Substring(d));// tai vi tri d  in ra chuoi con ve cuoi



// Code Result	 
// \n	New Line	
// \t	Tab	
// \b	Backspace	

Console.WriteLine("Hello \nWorld");
Console.WriteLine("Hello \tWorld");
Console.WriteLine("Hello \bWorld");