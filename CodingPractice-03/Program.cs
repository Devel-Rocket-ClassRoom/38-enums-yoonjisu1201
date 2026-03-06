using System;
/*
// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Console.WriteLine((int)Animal.Horse);
Console.WriteLine((int)Animal.Sheep);
Console.WriteLine((int)Animal.Monkey);

enum Animal
{
    Horse,      
    Sheep = 5,  
    Monkey      
}


//2.
CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;
Console.WriteLine(status);

[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}

//3.
CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Confused;
if ((status & CharacterStatus.Poison) != 0)
{
    Console.WriteLine("캐릭터가 독에 걸렸습니다.");
}
if ((status & CharacterStatus.Paralyzed) != 0)
{
    Console.WriteLine("캐릭터가 마비되었습니다.");
}
else
{
    Console.WriteLine("마비 상태가 아닙니다.");
}


[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}
//4.
CharacterStatus status = CharacterStatus.Poison;
Console.WriteLine($"초기 상태: {status}");

status |= CharacterStatus.Confused;
Console.WriteLine($"혼란 추가: {status}");

status &= ~CharacterStatus.Poison;
Console.WriteLine($"독 제거: {status}");

status ^= ~CharacterStatus.Invisible;
Console.WriteLine($"투명 토글: {status}");


[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}*/
//5.
BuffStatus status;
void ApplyBuff()
{

}

void RemoveBuff()
{

}

bool HasBuff()
{

}

[Flags]
enum BuffStatus
{
    None = 0,
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2,
    All = AttackUp | DefenseUp | SpeedUp
}