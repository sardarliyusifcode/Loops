#region Task 1



//double num = 25;
//int pow = 0;
//while (num >= 2)
//{
//    num /= 2;
//    pow++;
//}
//if (num == 1){
//    Console.WriteLine("Eded " + pow + "-in quvvetidir");
//}else if (num <= 1.5){
//    Console.WriteLine("Eded " + pow + "-in quvvetine yaxindir");
//}else{
//    pow++;
//    Console.WriteLine("Eded " + pow + "-in quvvetine yaxindir");
//}


#endregion

#region Task 2

//int num = 120457613;
//int sum = 0;

//while (num>0)
//{
//    sum += num % 10;
//    num /= 10;
//}
//Console.WriteLine(sum);
#endregion

#region Task 3

int num = 23;
int numOfDivider = 2;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        numOfDivider++;
        break;
    }
}
if (numOfDivider == 3)
{
    Console.WriteLine("Eded murekkebdir");
}
else
{
    Console.WriteLine("Eded sadedir");
}
#endregion