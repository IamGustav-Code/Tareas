// Ejercicio 1
//int numpar = 2;



//if ( numpar %2 == 0 )
//{
//    Console.WriteLine("El Numero es Par!");
//}
//else
//{
//    Console.WriteLine("El Numero es Impar!");
//}

//Ejercicio 2-----------------------------------------------

//int num1 = 0;

//if (num1 < 0  )
//{
//    Console.WriteLine("El Numero es Negativo!");
//}
//else  if (num1 > 0)
//{
//    Console.WriteLine("El Numero es Positivo!");
//}
//else if (num1 == 0)
//{
//    Console.WriteLine(" El Numero es Cero!");
//}

// Ejercicio 3------------------------------------

//int edad = 50;

//if (edad >= 18)
//{
//    Console.WriteLine("Es Mayor de Edad");
//}
//else
//{
//    Console.WriteLine("No es Mayor de Edad");
//}




//ejercicio 5

//int num1  = 35;


//if (num1 >= 10 & num1 <=20  )
//    {
//    Console.WriteLine(" El Numero esta entre 10 y 20!");
//}
//else
//    {
//    Console.WriteLine(" El Numero No Esta entre 10 y 20!");
//}


//Ejercicio 6-----------------------------------------------------------

//string Letra = "j";

//if ( )
//{

//}

// Ejercicio 7: -----------------------------------------------------------


//int num = 20;

//if (num % 3 == 0 & num % 5 == 0)
//{
//    Console.WriteLine("Se Puede Dividir por 3 y por 5 !!");
//}
//else
//{
//    Console.WriteLine( "No se Puede Dividir !!");
//}

//Ejerdcicio 8: -------------------------------------------------------------

//int año = 2025;

//if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
//{
//    Console.WriteLine($"{año} es un año bisiesto.");
//}
//else
//{
//    Console.WriteLine($"{año} no es un año bisiesto.");
//}


// Ejercicio 9: -------------------------------------------------------


//Console.Write("Ingresa una cadena: ");
//string texto = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(texto))
//{
//    Console.WriteLine("La cadena está vacía o contiene solo espacios.");
//}
//else
//{
//    Console.WriteLine("La cadena tiene contenido válido.");
//}

// Ejercicio 10: -----------------------------------------------------------------

//Console.Write("Ingresa el primer número: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Ingresa el segundo número: ");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 % num2 == 0)
//{
//    Console.WriteLine($"{num1} es múltiplo de {num2}.");
//}
//else
//{
//    Console.WriteLine($"{num1} no es múltiplo de {num2}.");
//}
//Se usa num1 % num2 == 0 para verificar si el residuo es cero (lo que indica que num1 es múltiplo de num2).

// Ejercicio 11:-------------------------------------------------------------------

//int lado1   = 10;
//int lado2 = 25;
//int lado3 = 50;


//if (lado1 == lado2 && lado2 == lado3)
//{
//    Console.WriteLine("El triángulo es Equilátero.");
//}
//else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
//{
//    Console.WriteLine("El triángulo es Isósceles.");
//}
//else
//{
//    Console.WriteLine("El triángulo es Escaleno.");
//}

// Ejercicio 12:------------------------------------------------------------------

//int Num = 7;
//if (Num == 2 & Num % Num == 0)
//{
//    Console.WriteLine("Numero Primo");

//}
//else
//{
//    Console.WriteLine("No es Primo!");
//}

// Ejercicio 13: --------------------------------------------------------------------
//Console.WriteLine("Escriba un solo caracter");


//char caracter = char.Parse (Console.ReadLine());

//if (char.IsDigit(caracter))
//{
//    Console.WriteLine(caracter + " No es una Letra");
//}
//else if (char.IsLetter(caracter))
//{
//    Console.WriteLine(caracter + " Es una Letra");
//}