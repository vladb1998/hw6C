Console.Write("Введите k1: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = "";

while (num > 0)
{
    if(num % 2 != 0) result += "1";
    else result += "0";
    num /= 2;
}
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[result.Length - 1 - i]);
}