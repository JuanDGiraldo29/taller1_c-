using System.Globalization;
using System.Reflection.Emit;
/*
//1. Calculadora de Fracciones
Console.WriteLine("Ingrese el numerador de la primera fraccion");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el denominador de la segunda fraccion");
int d1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numerador de la segunda fraccion");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el denominador de la segunda fraccion");
int d2 = int.Parse(Console.ReadLine());
bool ciclo=false;
if(d1==0 || d2==0){
    Console.WriteLine("No se puede dividir entre 0");
    ciclo=true;
}

while(ciclo==false){
Console.WriteLine("Que operacion desea hacer?");
Console.WriteLine("Sumar '+'");
Console.WriteLine("Restar '-'");
Console.WriteLine("Multiplicar '*'");
Console.WriteLine("Dividir '/'");
string opc = Console.ReadLine();

int ResN = 0;
int ResD = 0;
switch (opc)
{
    case "+":
        ResN = (n1 * d2) + (n2 * d1);
        ResD = d1 * d2;
        Console.WriteLine($"El resultado de la operacion es: {ResN}/{ResD}");
        ciclo=true;
        break;
    case "-":
        ResN = (n1 * d2) - (n2 * d1);
        ResD = d1 * d2;
        Console.WriteLine($"El resultado de su opéracion es: {ResN}/{ResD}");
        ciclo=true;
        break;
    case "*":
        ResN = n1 * n2;
        ResD = d1 * d2;
        Console.WriteLine($"El resultado de su operación es : {ResN}/{ResD}");
        ciclo=true;
        break;
    case "/":
        ResN = n1 * d2;
        ResD = d1 * n2;
        Console.WriteLine($"El resultado de la operacion es : {ResN}/{ResD}");
        ciclo=true;
        break;
    default:
        break;
        
}
}
*/
/*
//2.Número especial
Console.WriteLine("Ingrese un numero");
int num=int.Parse(Console.ReadLine());
if(num%2==0 || num%3==0){
    Console.WriteLine("Su numero es divisible entre 2 o 3, No puede ser especial");
    }else if(num%5==0){
    Console.WriteLine("Su numero es divisible por 5. Es especial!!");
    }    
    else
    {
        Console.WriteLine("Su numero no es especial, no cumple con ninguna condicion");
        
    }
*/    
/*
 //3. Dias y semanas
 Console.WriteLine("Ingrese su edad");
 int edad=int.Parse(Console.ReadLine());
 int variable=edad;
 int i=0;
 int cont=0;

 while(i==0)
 {
    if(variable>=4){
        variable-=4;
        cont++;
    } else{
        i=i=1;
    }
}
int dias=edad*365 + cont;
int semanas=edad*52;

Console.WriteLine($"Han trascurrido {dias} dias con años bisiesto y {semanas} semanas");
*/

/*
//4.Sistema de Inicio de Sesión
int intentos=3;
for(int i=0;i<3; i++)
{
    Console.WriteLine("Ingrese usuario");
    string usuario=(Console.ReadLine());

    Console.WriteLine("Ingrese contraseña");
    string contraseña=(Console.ReadLine());
    if (usuario=="Admin" && contraseña=="1234")
    {
    Console.WriteLine("Acceso concedido");
    i=4;         
    }
    else{
    Console.WriteLine("Usuario o contraseña incorrecta");
    intentos-=1;
    Console.WriteLine($"Le quedan {intentos} intentos" );
}
}if(intentos==0){
    {
        Console.WriteLine("Acceso denegado");
    }
}    
*/

 