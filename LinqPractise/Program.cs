List<int> nums = new List<int>();

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    nums.Add(random.Next(-100, 100));
}

// Gösterme işini bir method ile yaparak daha temiz bir kod yazmayı amaçladım.
void Show(IEnumerable<int> numbers)
{
    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }
}

var evenNumbers = nums.Where(x => x % 2 == 0);
Console.WriteLine("---Even Numbers---");
Show(evenNumbers);
var oddNumbers = nums.Where(x => x % 2 != 0);
Console.WriteLine("---Odd Numbers---");
Show(oddNumbers);
var positiveNumbers = nums.Where(x => x > 0);
Console.WriteLine("---Positive Numbers---");
Show(positiveNumbers);
var negativeNumbers = nums.Where(x => x < 0);
Console.WriteLine("---Negaive Numbers---");
Show(negativeNumbers);
var numbersBetween15To22 = nums.Where(x => x > 15 && x < 22);
Console.WriteLine("---Numbers Between 15 && 22---");
Show(numbersBetween15To22);
var SquareNums = nums.Select(x => x * x);
Console.WriteLine("---Squared Numbers---");
Show(SquareNums);


