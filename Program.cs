// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*********[ Tres matrices básicas ]************/

// Crea una matriz para contener los valores enteros 0 a 9.​
Console.WriteLine("********************************************************");
int[] enteros = new int[10];
for (int i = 0; i < 10; i++)
{
    enteros[i] = i;
    Console.WriteLine(enteros[i]);
}

// Crea una matriz con los nombres 'Tim', 'Martin', 'Nikki' y 'Sara'.​
Console.WriteLine("********************************************************");
string[] nombres = new string[] {"Tim","Martin","Nikki","Sara"};
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
}

// Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​
Console.WriteLine("********************************************************");
bool[] verso = new bool[10];
for (int i = 0; i < 10; i++)
{
    verso[i] = i % 2 == 0;
    Console.WriteLine(verso[i]);
}


/*********[ Lista de Sabores ]************/

// Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes.
Console.WriteLine("********************************************************");
List<string> sabores = new List<string>();
sabores.Add("Manjar");
sabores.Add("Vainilla");
sabores.Add("Frutilla Natural");
sabores.Add("Pistacho con Menta");
sabores.Add("Pescado");
sabores.Add("Planato con Leche");
sabores.Add("Lucuma");

foreach (var item in sabores)
{
    Console.WriteLine(item);
}

// Imprime la longitud de esta lista después de construirla. ​
Console.WriteLine("********************************************************");
Console.WriteLine("La lista de helados tiene '{0}' sabores.", sabores.Count);

// Imprime el tercer sabor de la lista y luego elimina ese valor. ​
Console.WriteLine("********************************************************");
Console.WriteLine("El tercer helado es de sabor a {0}.", sabores[2]);
sabores.RemoveAt(2);

// Obtén la nueva longitud de la lista.
Console.WriteLine("********************************************************");
Console.WriteLine("La nueva longitud de la lista de helados es de '{0}' sabores.", sabores.Count);

/*********[ Diccionario de Información del Usuario ]************/

// Crea un diccionario que almacene tanto claves de cadena como valores de cadena.
Console.WriteLine("********************************************************");
Dictionary<string, string> usuarios = new Dictionary<string, string>();

// Añade pares clave/valor a este diccionario donde:
    // cada clave sea un nombre de la matriz de nombres​.
    // cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
Random random = new Random();
foreach (string nombre in nombres)
{
    int indice = random.Next(sabores.Count);
    string sabor = sabores[indice];
    usuarios.Add(nombre, sabor);
}

// Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​
foreach (KeyValuePair<string, string> usuario in usuarios)
{
    Console.WriteLine("A {0} le gusta el helado sabor a {1}.", usuario.Key, usuario.Value);
}