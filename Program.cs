// int randomNumber = new Random().Next(100,1000);
// int firstNumber = randomNumber / 100;
// int secondNumber = (randomNumber / 10) % 10;
// int thirdNumber = randomNumber % 10;
// Console.WriteLine(randomNumber);
// Console.WriteLine(firstNumber + "" + thirdNumber);

// Console.WriteLine("Введите первое число ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int second = Convert.ToInt32(Console.ReadLine());
// int ostatok = first % second;
// if (ostatok == 0)
// {
// Console.WriteLine("кратно");
// } else Console.WriteLine("не кратно, остаток " + ostatok);

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number % 7 == 0) && (number % 23 == 0)) 
// {
//     Console.WriteLine("Да");
// }  else Console.WriteLine("нет");

// Задача 10:

// Console.WriteLine("Enter 3 digits numbers: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int secondNumber = (number / 10) % 10;

// Console.WriteLine(secondNumber);

// Задача 13:

// Console.WriteLine("Enter 3 digits number: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// bool runIt = true;
// while (runIt == true){
//     Console.WriteLine(thirdNumber % 10);
//     if (thirdNumber < 100) {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     runIt = false;
// } 

// Задача 15:

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5) 
{
    Console.WriteLine("нет");
} else if (day == 6 || day == 7) {
    Console.WriteLine("да");
}