//variables
int opcion = 0;
string titulo_libro = string.Empty;
string autor = string.Empty;
string año_publicado = string.Empty;
string categoria = string.Empty;
int catego_num = 0;
//menu
do
{
    Console.WriteLine("");
    Console.WriteLine("1. Registrar libros");
    Console.WriteLine("2. Mostrar libros registrados");
    Console.WriteLine("3. Buscar libro por título");
    Console.WriteLine("4. Registrar libro por préstamo");
    Console.WriteLine("5. Devolver Libro");
    Console.WriteLine("6. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            //pedimos todos los datos necesarios
            Console.Write("Ingrese el titulo del libro:");
            titulo_libro = Console.ReadLine();
            Console.Write("Ingrese al autor del libro:");
            autor = Console.ReadLine();
            Console.Write("Ingrese el año de publicación:");
            año_publicado = Console.ReadLine();
            //mientras no escojan una opcion de categoria se repitre este menu
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ahora indique la categoria del libro.");
                Console.WriteLine("1. Ciencia");
                Console.WriteLine("2. Literatura");
                Console.WriteLine("3. Tecnología");
                Console.WriteLine("4. Historia");
                catego_num = int.Parse(Console.ReadLine());
                switch (catego_num)
                {
                    case 1:
                        categoria = ("Ciencia");
                        break;
                    case 2:
                        categoria = ("Literatura");
                        break;
                    case 3:
                        categoria = ("Tecnologia");
                        break;
                    case 4:
                        categoria = ("Historia");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            while (catego_num > 4 || catego_num < 1);
            break;
        case 2:
            //muestra los libros registrados
            Console.WriteLine("");
            Console.WriteLine("Los libros registrados son.");
            Console.WriteLine("Título: " + titulo_libro);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Categoria: " + categoria);
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        default: Console.WriteLine("Ingrese una opcion valida"); break;
    }
}
while (opcion != 6);

//Buscar libro por titulo
string libro = "";
string libroAlmacenado = "";

Console.WriteLine("Ingrese el titulo del libro:");
libro = Console.ReadLine();

if (libro == libroAlmacenado) ///variable
{
    Console.WriteLine("Advertencia, el libro ya esta prestado. ");
}
else
{
    Console.WriteLine("Libro prestado con exito. ");
}