// using System;

// namespace EnthusiasticMoose
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }
// Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine();


using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Random random = new Random();
// int randomNumber = random.Next(0, 2);
// if (randomNumber == 0)
// {
//     Console.WriteLine("Y");
// }
// else
// {
//     Console.WriteLine("N");
// }

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |         {message}  
                      \ / o| |o \ /         
                       |   / \   |    
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
MooseSays("did i do it?");

bool MooseAsks(string question)
{

    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool isTrue = MooseAsks("Is canada real?");

// bool MooseAsks(string question)
// {
//     Random random = new Random();
//     bool randomBool = random.Next(2) == 1; // 0 = false, 1 = true;

//     Console.WriteLine($"{question} (Y/N): {randomBool ? 'Y' : 'N'}");

//     return randomBool;
// }

// bool isTrue = MooseAsks("Is canada real?");  code does not work


if (isTrue)
{
    MooseSays("Really? It seems very unlikely.");
}
else
{
    MooseSays("I  K N E W  I T !!!");
}

Console.WriteLine(isTrue);

void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
}
void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}


//gives random y or n does not ask question
void SecretQuestion()
{
    var random = new Random();
    char randomChar = random.Next(2) == 1 ? 'y' : 'n';
    //bool wantsSecret = MooseAsks("Do you want to know a secret?");
    bool wantsSecret = randomChar == 'y';
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}


CanadaQuestion();
EnthusiasticQuestion();
LoveCSharpQuestion();
SecretQuestion();