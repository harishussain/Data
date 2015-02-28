using System;
enum days
{
    sunday, monday, tuesday, Wednesday,
    thursday, friday, saturday
}

class EnumDemo
{
   
    public static void Main() {
//string[] color = {
//"Red",
//"Yellow",
//"Red",
//"Red",
//"Red",
//"Reddish Green"
//};
days i;		 // declare an enum variable
// use i to cycle through the enum
for (i = days.sunday; i <= (days.saturday); i++)
{
    Console.WriteLine(i + " has value of " + (int)i);
    Console.WriteLine();
}
// use an enumeration to index an array
//for(i = Apple.Jonathan; i <= Apple.McIntosh; i++)
//Console.WriteLine("Color of " + i + " is " +
//color[(int)i]);
Console.ReadLine();
}


}
