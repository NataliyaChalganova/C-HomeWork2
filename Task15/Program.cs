Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("да, это выходной");
  }
  else Console.WriteLine("нет, это будний день");
}


CheckingTheDayOfTheWeek(day);