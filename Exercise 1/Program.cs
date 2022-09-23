// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//დაბეჭდავს კლავიატურიდან შემოტანილ ტექსტს.(სახელს და გვარს)

string name = Console.ReadLine();
Console.WriteLine(name);

//კლავიატურიდან შემოიტანს ორ რიცხვს და დაბეჭდავს მათ :
//ჯამს , სხვაობას, ნამრავლს, პირველი რიცხვის მეორეზე გაყოფის ნაშთს.

int x, y;

Console.WriteLine("input I number");
string number1 = Console.ReadLine();
int.TryParse(number1, out x);

Console.WriteLine("input II number");
string number2 = Console.ReadLine();
int.TryParse(number2, out y);

Console.WriteLine($"jami = {x + y}");

Console.WriteLine($"sxvaoba = {x - y}");

Console.WriteLine($"namravli = {x * y}");

Console.WriteLine($"nashtiani gayofa = {x % y}");

//კლავიატურიდან შემოიტანს ორ რიცხვს და გაუცვლის მათ მნიშვნელობას

int num1, num2, j;
string z, t;

z = Console.ReadLine();
int.TryParse(z, out num1);

t = Console.ReadLine();
int.TryParse(t, out num2);

j = num1;
num1 = num2;
num2 = j;
Console.WriteLine($"{num1}, {num2}");

//კონსოლიდან (კლავიატურიდან) შემოიტანს 4 რიცხვს და გამოითვლის ამ რიცხვების საშუალოს.

double a, b, c, f;
string a1, a2, a3, a4;

a1 = Console.ReadLine();
double.TryParse(a1, out a);

a2 = Console.ReadLine();
double.TryParse(a2, out b);

a3 = Console.ReadLine();
double.TryParse(a3, out c);

a4 = Console.ReadLine();
double.TryParse(a4, out f);

Console.WriteLine((a + b + c + f) / 4);


// კელვინს გადაიყვანს ცელსიუსში

double k_to_c = -273.15;
double kelvin;

Console.WriteLine("input kelvin");

string input = Console.ReadLine();
double.TryParse(input, out kelvin);

double celsius = kelvin + k_to_c;

Console.WriteLine($"{kelvin} kelvin is {celsius} celsiusi");

//კლავიატურიდან შემოიტანს რიცხვს და თუ ეს რიცხვი დადებითია დაბეჭდავს ტექსტ “number is positive”

int number4;

Console.WriteLine("input number");

string input_number = Console.ReadLine();

int.TryParse(input_number, out number4);

if (number4 > 0)
{
    Console.WriteLine("number is positive");
}

//კლავიატურიდან შემოიტანს 3 რიცხვს და დაბეჭდავს ამ 3 რიცხვიდან უმცირესს /უდიდესს

int y1, y2, y3;

Console.WriteLine("input first number");

string input_num = Console.ReadLine();
int.TryParse(input_num, out y1);

Console.WriteLine("input second number");

string input_num2 = Console.ReadLine();
int.TryParse(input_num2, out y2);

Console.WriteLine("input third number");

string input_num3 = Console.ReadLine();
int.TryParse(input_num3, out y3);

if (y1 > y2 && y1 > y3)
{
    Console.WriteLine($"max {y1}");
    Console.WriteLine($"min {(y2 < y3 ? y2 : y3)}");
}
else if (y1 < y2 && y2 > y3)
{
    Console.WriteLine($"max {y2}");
    Console.WriteLine($"min {(y1 < y3 ? y1 : y3)}");
}
else
{
    Console.WriteLine($"max {y3}");
    Console.WriteLine($"min {(y1 < y2 ? y1 : y2)}");
}




//კლავიატურიდან შემოიტანს ორ რიცხვს და თუ ეს ორი რიცხვი ტოლია გაზრდის მათ მნიშვნელობებს 3 ჯერ

int x1, x2;

Console.WriteLine("input first number");

string input_num1 = Console.ReadLine();
int.TryParse(input_num1, out x1);

Console.WriteLine("input second number");

string input_num21 = Console.ReadLine();
int.TryParse(input_num21, out x2);

if (x1 == x2)
{
    Console.WriteLine(x1 * 3);
}



//კლავიატურიდან შემოტანილ რიცხვს შეამოწმებს არის თუ არა 7 -ის ჯერადი

int z1;

Console.WriteLine("input number");

string input_num31 = Console.ReadLine();
int.TryParse(input_num31, out z1);

if (z1 % 7 == 0)
{
    Console.WriteLine($"{z1} is divisible by 7");
}



//კლავიატურიდან შემოიტანს რიცხვს და დაბეჭდავს შეიცავს თუ არა ეს რიცხვი ციფრ 5-ს.



Console.WriteLine("input number");

string input_num4 = Console.ReadLine();

for (int i2 = 0; i2 < input_num4.Length; i2++)
{
    if (input_num4[i2] == '5')
    {
        Console.WriteLine("contains 5");
        break;
    }
    else if (i2 == input_num4.Length - 1)
    {
        Console.WriteLine("does not contain 5");
    }
}






//კლავიატურიდან შემოიტანს ამ რიცხვს და დაბეჭდავს ამ რიცხვის ციფრებს.
//(მაგ 324 უნდა დაბეჭდოს 3 2 4


Console.WriteLine("input number");

string input_num5 = Console.ReadLine();

for (int i1 = 0; i1 < input_num5.Length; i1++)
{
    Console.WriteLine(input_num5[i1]);
}