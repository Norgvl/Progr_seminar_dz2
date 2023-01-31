string[] array = new string[7];
array[0] = "Нет";     //Понедельник
array[1] = "Нет";     //"Вторник"
array[2] = "Нет";    //"среда"
array[3] = "Нет";     //"Четверг"
array[4] = "Нет";     //"Пятница"
array[5] = "Да";     //"Суббота"
array[6] = "Да";    //"Воскресенье"

int dayOfWeek = int.Parse(Console.ReadLine());
if (dayOfWeek > 7 || dayOfWeek < 1) Console.WriteLine($"{dayOfWeek} не день недели");
else Console.WriteLine(array[dayOfWeek-1]);