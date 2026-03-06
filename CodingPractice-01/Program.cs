using System;
/*
// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Priority priority = Priority.High;

if (priority == Priority.High)
{
    Console.WriteLine("높은 우선순위");
}

enum Priority
{
    High,
    Normal,
    Low
}

//2.
Animal animal = Animal.Tiger;
Console.WriteLine(animal);

if (animal == Animal.Tiger)
{
    Console.WriteLine("호랑이");
}
enum Animal
{
    Mouse,
    Cow,
    Tiger
}

//3.
int red = (int)Color.Red;
int green = (int)Color.Green;
int blue = (int)Color.Blue;
Console.WriteLine($"Red: {red}, Greed: {green}, Blue: {blue}");

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

//4.
Console.WriteLine(sizeof(SmallEnum));

enum SmallEnum : byte
{
    Left,
    Right, 
    Top, 
    Bottom
}

//5.
Type colorType = typeof(ConsoleColor);

string[] colors = Enum.GetNames(colorType);

Console.WriteLine("ConsoleColor 열거형의 색상들: ");
foreach (var color in colors)
{
    Console.WriteLine(color);
}

//6.
string colorName = "Red";
ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);

Console.ForegroundColor = color;
Console.WriteLine("빨간색 테스트");
Console.ResetColor();
Console.WriteLine("기본색상 테스트");

//7.
string input = "Up";

if (Enum.TryParse(input, out Direction direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}
else
{
    Console.WriteLine("변환 실패");
}

string invalid = "Forward";
{
    if (Enum.TryParse(invalid, out Direction result))
    {
        Console.WriteLine($"변환 성공: {result}");
    }
    else
    {
        Console.WriteLine($"\'{invalid}\'은(는) 유효하지 않은 값");
    }
}

enum Direction
{
    Up,
    Down, 
    Left, 
    Right
}

//8.
bool isValid1 = Enum.IsDefined(typeof(Animal), 1);
Console.WriteLine($"1은 유효한 Animal 값인가? {isValid1}");

bool isValid2 = Enum.IsDefined(typeof(Animal), 100);
Console.WriteLine($"100은 유효한 Animal 값인가? {isValid2}");

bool isValid3 = Enum.IsDefined(typeof(Animal), "Tiger");
Console.WriteLine($"\'Tiger\'는 유효한 Animal 값인가? {isValid3}");
enum Animal
{
    Mouse,
    Cow,
    Tiger
}

//9.
Direction dir = Direction.Right;
int num = (int)dir;
Console.WriteLine($"{dir} = {num}");

int value = 2;
Direction direction = (Direction)value;
Console.WriteLine($"{value} = {direction}");

enum Direction
{
    Up, Down, Left, Right
}
*/
//10.
Animal invalid = (Animal)100;
Console.WriteLine(invalid);

enum Animal
{
    Mouse,
    Cow,
    Tiger
}