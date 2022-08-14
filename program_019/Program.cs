// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
bool NumberCheck (string str){
    if (str.Length < 5 | str.Length > 5) {
        System.Console.WriteLine($"Число {str} не является пятизначным");
        return false;
        }
    else {
        string FlippedOver = "";
        for (int i = 1; i <= str.Length; i++) FlippedOver += str[^i];
        if (str== FlippedOver) return true;
        else return false;
        }
}

System.Console.Write("Введите пятизначное число: ");
string read = System.Console.ReadLine()!;
System.Console.WriteLine(NumberCheck(read));