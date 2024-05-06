string[] estudiantes = new string[] { "Sergio", "Santiago", "Motoa" };
string[] materias = new string[] { "Calculo Diferencial" };
int[] promedio = new int[estudiantes.Length];
int[] notas = new int[5];

for (int i = 0; i < estudiantes.Length; i++)
{
    for (int j = 0; j < notas.Length; j++)
    {
        Console.WriteLine($"{estudiantes[i]} por favor ingresar su calificacion #{j+1} para {materias[0]}");
        notas[j] = Convert.ToInt16(Console.ReadLine());
        promedio[i] += notas[j];
    }
}
for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"{estudiantes[i]} su promedio es {promedio[i] / 5}");
}
