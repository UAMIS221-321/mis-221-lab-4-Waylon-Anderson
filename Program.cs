Random rnd = new Random();
int number = rnd.Next(8, 13); // The pizza slice itself 
System.Console.WriteLine(number);

string UserInput = null;
int rows = number;

// Main


while(UserInput != "4"){
    System.Console.WriteLine("What would you like to see?\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
    UserInput = GetUserChoice();
    UserMenu(UserInput, rows);
}

// End Main

//
////
////// Menu
////
//

static void UserMenu(string UserInput, int rows){
    if(UserInput == "1"){
        PlainPizza(rows);
    }
    else if(UserInput == "2"){
        CheesePizza(rows);
    }
    else if(UserInput == "3"){
        PepperoniPizza(rows);
    }
    else if(UserInput == "4"){
        System.Console.WriteLine("Thanks for stopping by!");
        Pause();
    }
    else{
        System.Console.WriteLine("This is an invalid choice, please choose again.");
        Pause();
    }
}

//
////
////// Main Methods
////
//


static void PlainPizza(int rows){
    System.Console.WriteLine();
    for(int i = rows; i > 0; i--){
        System.Console.Write("* ");
    for(int j = 1; j < i ; j++){ //first
        System.Console.Write("* ");
    }
    System.Console.WriteLine();//last 
    }
    System.Console.WriteLine("Here is your pizza!");
    Pause();
}

static void CheesePizza(int rows){
    for(int j = 0; j < rows; j++){
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
    for(int i = rows - 2; i > 0; i--){
        System.Console.Write("* ");
    for(int j = 1; j < i ; j++){ //first
        System.Console.Write("# ");
    }
    System.Console.Write("*");
    System.Console.WriteLine();//last 
    }
    System.Console.WriteLine("*");
    System.Console.WriteLine("Here is your pizza!");
    Pause();
}

static void PepperoniPizza(int rows){
    for(int j = 0; j < rows; j++){
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
    for(int i = rows - 2; i > 0; i--){
        System.Console.Write("* ");
    for(int j = 1; j < i ; j++){ //first
        Random rnd = new Random();
        int number = rnd.Next(0, 8);
        if(number == 0 ){
            System.Console.Write("[]");
        }
        else{
            System.Console.Write("# ");
        }
    }
    System.Console.Write("*");
    System.Console.WriteLine();//last 
    }
    System.Console.WriteLine("*");
    System.Console.WriteLine("Here is your pizza!");
    Pause();
}

//
////
///// Primary methods
////
//

static void Pause(){
    System.Console.ReadKey();
    Console.Clear();
}

static string GetUserChoice(){
    return System.Console.ReadLine();
}