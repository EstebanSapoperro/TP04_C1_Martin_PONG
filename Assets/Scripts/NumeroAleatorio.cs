using System.Collections.Generic;
using UnityEngine;

public class NumeroAleatorio : MonoBehaviour
{
    static List<int> numerosUsados = new List<int>();

    public static int ObtenerNumero(int minimo, int maximo)
    {
        if (numerosUsados.Count >= maximo - minimo + 1)
        {
            Debug.Log("Ya se usaron todos los números.");
            return -1;
        }

        int numero;

        do
        {
            numero = Random.Range(minimo, maximo + 1);
        }
        while (numerosUsados.Contains(numero));

        numerosUsados.Add(numero);

        return numero;
    }

    public static void ReiniciarNumeros()
    {
        numerosUsados.Clear();
    }
}
