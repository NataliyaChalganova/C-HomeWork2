Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(n);
if (a.Length > 2)
{
  Console.WriteLine ("третья цифра -" + a [2]);
}
else
{
  Console.WriteLine ("третьей цифры нет");
}












