Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

bool isAgeValid = int.TryParse(ageText, out int age);

int ageIn25 = age + 25;
int age25Ago = age - 25;

Console.WriteLine($"In 25 years, you will be {ageIn25} years old; 25 years ago, you were {age25Ago} years old.");
