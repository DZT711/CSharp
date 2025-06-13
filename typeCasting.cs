// Implicit Casting(automatically) -converting a smaller type to a larger type size
// char -> int -> long -> float -> double

int myInt = 5;
double myDouble = myInt;//auto casting
Console.WriteLine(myDouble);
Console.WriteLine(myInt);
// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

double mynewDouble = 9.8;
int myNewInt = (int)mynewDouble;
Console.WriteLine(mynewDouble);
Console.WriteLine(myNewInt);

int myInt2 = 10;
double myDouble2 = 5.25;
bool myBool2 = true;

Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string