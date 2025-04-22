using appcalculadora2.Logica;

Console.WriteLine("SUMAR s, RESTAR r, MULTIPLICAR m, DIVIDIR d");
Console.WriteLine("Seleccione Opción");
string opcion=Console.ReadLine();
Calculadora cal= new();
Console.WriteLine("Ingrese 2 valores separados por ENTER");
int n1=int.Parse(Console.ReadLine());
int n2=int.Parse(Console.ReadLine());
int res=opcion=="s"?cal.Sumar(n1,n2):0;
Console.WriteLine("RESULTADO: "+res);
