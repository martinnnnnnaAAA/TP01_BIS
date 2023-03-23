using System.Collections.Generic;
int curso = 0;
int estudiantes = 0;
int dineroTotal = 0;
int menu = 0;
Dictionary<int, int> dicRecaudado= new Dictionary<int, int>();
do{
    Console.WriteLine("1. Ingresa los importes de un curso");
    Console.WriteLine("2. Ver estadísticas");
    Console.WriteLine("3. Salir");
    menu = int.Parse(Console.ReadLine());
switch(menu) 
{
  case 1:
curso = pedirInt("ingresar numero de curso");
estudiantes = pedirInt("ingresar cantidad de estudiantes del curso ");
dineroTotal = pedirDinero(estudiantes);
dicRecaudado.Add(curso,dineroTotal);
    break;
  case 2:
Console.WriteLine("El curso que mas plata puso fue " + dicRecaudado.Keys.Max());
Console.WriteLine("El promedio de plata regalada por todos los cursos fue "+dicRecaudado.Values.Average());
Console.WriteLine("La reaudacion entre todos los cursos fue "+dicRecaudado.Values.Sum());
Console.WriteLine("La cantidad de cursos que participaron del regalo fueron"+dicRecaudado.Keys.Count());
    break;
}
}while(menu != 3);

int pedirInt(string frase)
{
Console.WriteLine(frase);
int respuesta = int.Parse(Console.ReadLine());
return respuesta;
}
int pedirDinero(int estudiantes)
{
    int estudianteInd = 0; 
int dineroTotal= 0;
for (int i = 0; i < estudiantes; i++)
{
    Console.WriteLine("Ingresar dinero estudiante " + (i+1));
    estudianteInd = int.Parse(Console.ReadLine());
    dineroTotal= dineroTotal + estudianteInd;
}
return dineroTotal;
}
