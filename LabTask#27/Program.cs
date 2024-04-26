
string[] arr = { "Ali", "Murad", "Pesha", "Nicat", "Qadir" };

head:
Console.WriteLine("Zehmet olmasa bir herf daxil edin: ");
string input = Console.ReadLine();
bool checkChar = char.TryParse(input, out char letter);
if (!checkChar) goto head;

Console.WriteLine("------------------------------");
 void  ArrayWords(char ch)
{
    int location = 0;
    foreach (var item in arr)
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (item[i] == ch)
            {
                location = i + 1;
                Console.WriteLine($"{item} - {ch} herfinin yeri :  {location}");
            }
          
        }
    }
}

ArrayWords(letter);

