/* Задача 4: Напишите программу,
             которая принимает на вход три числа
             и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Сравнниваем три  числа между собой.");

Console.Write("Введите первое число: ");
int A= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

if  ((A == B)&&(B==C))
 {
     Console.WriteLine("Все числа равны между собой.");
 }
 else if ((A > B)&&(A > C))
 {
     Console.WriteLine("Максимальное первое число: " + A);
 }
 else if (B > C)
 {
     Console.WriteLine("Максимальное второе число: " + B);
}
 else 
  {
        Console.WriteLine("Максимальное третье число: " + C);
  }
// //  Ура!!! Это моя вторая программа написанная самостоятельно.