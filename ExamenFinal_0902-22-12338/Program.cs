using System;
class Program
{
    static void Main()
    {
        /* 
         * Correccion 1:
         * Al definir matrices se deben utilizar corchetes
         */
        int[,] matriz = new int[3, 2];
        //Asignamos valores a los elementos de la matriz
        /* 
         * Correccion 2:
         * Hay un error al querer asignarle los valores a la matriz y se asignan valores a 6 elementos de la matriz,
         * pero la matriz solo tiene 3 filas y 2 columnas, esto provocará 
         * como resultado una excepción de índice fuera de los límites de la matriz .
         * Para corregir esto, es necesario eliminar los intentos de asignar valores
         * a matriz[2,0] y matriz[2,1].
         */
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        //Imprimimos los valores de la matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Elemento en la posición [{0},{1}]:{2}", i, j, matriz[i, j]);
            }
        }
        Console.ReadLine();
    }
}
