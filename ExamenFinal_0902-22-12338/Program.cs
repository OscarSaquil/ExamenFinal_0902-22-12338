using System

class Program
{
    static void Main()
    {
        int[,] matriz = { 3, 2 };
        //Intentamos asignar valores a los elementos de la matriz
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        matriz[2, 0] = 5;
        matriz[2, 1] = 6;
        //Intentamos imprimir los valores de la matriz
        for(int i = 0; i < 3; i++) { 
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("Elemento en la posición [{0},{1}]:{2}", i, j, matriz[i,j]);
            }
        }
        Console.ReadLine();
    }
}