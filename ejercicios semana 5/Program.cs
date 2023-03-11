
void saludo(string nom_saludo)
{
    Console.WriteLine($"Hola {nom_saludo} gusto de saludarte");
}

void desglose(string nom)
{
    String nuevo = nom.ToUpper();
 
    string r = "";
    
    for (int c= 0; c < nuevo.Length; c++)

    {
        Console.SetCursorPosition(10+c, 10 );
        Console.Write(nuevo[c] + " ");
        r = r + nuevo[c] .ToString() .ToLower();
        Thread.Sleep(1000);
    }

    Console.WriteLine("minusculas" + r);
   
}
int calculo(int edad)
{
    int añoNac = 2023 - edad;
    return añoNac;
}

String nombre;
int edad;
int año;
desglose("Maria");

Console.WriteLine("Cual es tu nombre");
nombre = Console.ReadLine();
saludo(nombre);
Console.WriteLine("cuantos años tienes?");
edad = Convert.ToInt32(Console.ReadLine());
año = calculo(edad);
Console.WriteLine($"Naciste en el año: {año}");

Console.WriteLine($"Wow {nombre} esa edad de {edad} es genial");

//Cuando un bloque de código devuelve resulatdo se conoce como funcion y cuando no devuelv el resultado se conoce como metodo.
//Y cundo no queremos devolver nada se conoce como void pero cuando es una funcion vamos a definir el tipo de dato que va a devolver.