Console.Write("Введите имя пользователя:");
string usernume = Console.ReadLine();

if(usernume.ToLower() == "маша")
{
    Console.Write("Ура это же МАША!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usernume);
}