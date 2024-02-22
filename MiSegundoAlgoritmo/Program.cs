// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Realizar un algoritmo que me pida 3 números por pantalla, con el primer número hallar el cuadrado, con el segundo numero
hallar la raíz cuadrada y con el tercer número hallar la raíz cubica. mostrar en pantalla los 3 resultados aritméticos.
Recuerda concatenar bien los strings para mostrar un mensaje bonito
    //Declaración Variables
    double num1, num2, num3;
double Cuad, Rcuad, Rcub;
Console.Write("Ingrese el primer nùmero: ");
num1 = Convert.ToInt32(Console.ReadLine()); //Todo lo que ingrese en esta lìnea, serà tomado como un STRING
Console.WriteLine(" ");
//leer num1
Console.Write("Ingrese el segundo nùmero: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Ingrese el tercer nùmero: ");
num3 = Convert.ToInt32(Console.ReadLine());
//Hacer los càlculos!
Cuad = num1 ^ 2;
Rcuad = num2 √;
Rcub = num3 √3;


//Imprimir en pantalla
Console.WriteLine("Cuadrado: " + num1 + " "^2); //1ra Forma para concatenar textos

Console.WriteLine("Raiz Cuadrada: " + num2 + " "√);

Console.WriteLine("Raiz Cubica: " + num3 + " "√3);