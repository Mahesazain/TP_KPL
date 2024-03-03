// See https://aka.ms/new-console-template for more information
// Bagian A
Console.WriteLine("Soal A");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Masukan satu huruf :");
    String huruf = Console.ReadLine();

    if (huruf == "A" || huruf == "a" || huruf == "I" || huruf == "i" || huruf == "U" || huruf == "u" || huruf == "E" || huruf == "e" || huruf == "O" || huruf == "o")
    {
        Console.WriteLine("Huruf " + huruf + " merupakan huruf vokal");
    }
    else
    {
        Console.WriteLine("Huruf " + huruf + " merupakan huruf konsonan");
    };
    Console.WriteLine();
};

Console.WriteLine();


//Bagian B
Console.WriteLine("Soal B");
int[] angkaGenap = {1,2,3,4,5,6,7,8,9,10};
Console.WriteLine("List Array yang dibuat: ");
for (int i = 0; i < angkaGenap.Length; i++)
{
    Console.Write($"{angkaGenap[i]} ");
};
Console.WriteLine();
int count = 0;
for (int i = 0; i < angkaGenap.Length; i++)
{
    if (angkaGenap[i] % 2 == 0)
    {
        count++;
        Console.WriteLine($"Angka genap {count}: {angkaGenap[i]}");
    }
};
