Console.WriteLine("Введите целое число");
int A = int.Parse(Console.ReadLine());
int count = 1;
if (A < 2)
{
    Console.WriteLine("В промежутке от 1 до числа " + A + " нет четных чисел");
}
else
{
   while (count <= A)
    {
       if ((count % 2) == 0 )
       {
            Console.Write(count + ", ");
            count = count + 1;
       } 
    }
}