// WHILE LOOP
bool game1 = true;
Console.BackgroundColor=ConsoleColor.Black;
while (game1==true){
    Console.WriteLine("Welcome to the game! Pick a number between 10 and 99!");
    string input = Console.ReadLine();
    input= input.ToUpper();
    if (input == "EXIT")
    {Console.WriteLine("thank you for playing");
    System.Environment.Exit(0);    
    }
    else{
    
    int usernum = int.Parse (input);
    if (usernum < 10) {
        Console.WriteLine("that number is too low");
        continue;
    }
else if (usernum > 99){
            Console.WriteLine("oops your number is to large");
           
        }
    else {
        Console.WriteLine(usernum);
        int answer1 = usernum % 23;
Console.WriteLine(answer1);   
if (answer1 == 0){
   
    Console.BackgroundColor=ConsoleColor.Green;
    Console.Clear();
    Console.WriteLine(usernum);
    Console.WriteLine(answer1);
    Console.ReadKey();
    Console.BackgroundColor=ConsoleColor.Black;
    Console.Clear();
    game1=false;
}
else {
   Console.BackgroundColor=ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine(usernum);
    Console.WriteLine(answer1);
    Console.ReadKey();
    Console.BackgroundColor=ConsoleColor.Black;
    Console.Clear();
    game1=false;    
}
    }
}
}
//DO LOOP
Console.WriteLine("press any key to continue");
Console.ReadKey();
bool game2 = true;
do {
    Console.WriteLine("Welcome to game 2! Pick a number between 10 and 99!");
string input2 = Console.ReadLine();
    if (input2 == "exit" || input2=="Exit" )
    {
    Console.WriteLine("thanks for playing!");
    System.Environment.Exit(0);
    }
    else{
    int usernum = Int32.Parse (input2);
    if (usernum < 10) {
        Console.WriteLine("that number is too low");
        continue;
    }
else if (usernum > 99){
            Console.WriteLine("oops your number is to large");
           
        }
    else {
                Console.WriteLine(usernum);
                int answer2 = usernum % 34;
        Console.WriteLine(answer2);
        if (answer2 == 0){
        
            Console.BackgroundColor=ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(usernum);
            Console.WriteLine(answer2);
            Console.ReadKey();
            Console.BackgroundColor=ConsoleColor.Black;
            Console.Clear();
            game2=false;
        }
        else {
        Console.BackgroundColor=ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(usernum);
            Console.WriteLine(answer2);
            Console.ReadKey();
            Console.BackgroundColor=ConsoleColor.Black;
            Console.Clear();
            game2=false;    
            }
            }
    }
} while (game2==true);
//FOR LOOP
Console.WriteLine("press any key to continue");
Console.ReadKey();
for (int game3=0; game3<1;game3++){
  Console.WriteLine("Welcome to game 3! Pick a number between 10 and 99!");
    string input=Console.ReadLine();
    if (input== "exit" || input== "Exit")
    {
        Console.WriteLine("thanks for playing!!");
    }
    else{
    int usernum = Int32.Parse (input);
    if (usernum < 10) {
        Console.WriteLine("that number is too low");
        continue;
    }
else if (usernum > 99){
            Console.WriteLine("oops your number is to large");
           
        }
    else {
                Console.WriteLine(usernum);
                int answer3 = usernum % 33;
        Console.WriteLine(answer3);
        if (answer3 == 0){
        
            Console.BackgroundColor=ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(usernum);
            Console.WriteLine(answer3);
            Console.ReadKey();
            Console.BackgroundColor=ConsoleColor.Black;
            Console.Clear();
        }
        else {
        Console.BackgroundColor=ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(usernum);
            Console.WriteLine(answer3);
            Console.ReadKey();
            Console.BackgroundColor=ConsoleColor.Black;
            Console.Clear();   
            }
            }  
    
    }
}

bool stillPlaying = true;
while (stillPlaying) {
Console.Clear();
Console.WriteLine("THE CALCULATOR! ");
Console.WriteLine("(1) ADD\n(2) SUBTRACT\n(3) MULTIPLY\n(4) DIVIDE\n(5) EXIT\n PLEASE CHOOSE A NUMBER");
int choice = Int32.Parse(Console.ReadLine());
int num1=0;
int num2=0;
if (choice<5 && choice>0){
Console.Write("please give your first number: ");
num1 = Int32.Parse(Console.ReadLine());
Console.Write("please give your second number: ");
num2 = Int32.Parse(Console.ReadLine());
}
switch (choice){
    case 1:
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
    
    default:
        Console.WriteLine("Thanks for calculating");
        stillPlaying = false;
        break;
} 
Console.WriteLine("press any key to continue");
Console.ReadKey();
}
