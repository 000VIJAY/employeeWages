int isFullTime = 1;
Random rnd = new Random();
int num = rnd.Next(0, 2);
if (num == isFullTime)
{
    Console.WriteLine("Present");
}
else
    Console.WriteLine("Absent");