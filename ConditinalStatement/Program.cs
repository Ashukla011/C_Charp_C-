// See https://aka.ms/new-console-template for more information
//  Convert.toChar -> used to convert int to str
// Conditional and switch statement 

char ch;
Console.WriteLine("Enter The Day Name:");
ch =Convert.ToChar(Console.ReadLine());
 switch(ch)
 {
    case 'a':
    Console.WriteLine("Monday");
    break;

    case 'b':
    Console.WriteLine("Tuesday");
    break;

    case 'c':
    Console.WriteLine("Wensday");
    break;
    
    case 'd':
    Console.WriteLine("Thursday");
    break;

    case 'f':
    Console.WriteLine("Friday");
    break;

    case 'g':
    Console.WriteLine("Suterday");
    break;

    case 'h':
    Console.WriteLine("Sunday");
    break;

    default :
    Console.WriteLine("Sorrynotmatching");
    break;

 }

//  Secound case :
char ch;
Console.WriteLine("Enter The Day Name:");
ch =Convert.ToChar(Console.ReadLine());
 switch(ch)
 {
    case 'a':
    case 'u':  
    case 'i':   
    case 'o':    
    case 'e':
     Console.WriteLine("Vowel");
     break;

    default :
    Console.WriteLine("it is consonent");
    break;

 }