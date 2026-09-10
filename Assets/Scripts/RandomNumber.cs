using System.Collections.Generic;
using UnityEngine;


public class RandomNumber : MonoBehaviour
{
    static List<int> usedNumbers = new List<int>();

    public static int ObteinRandomNumber(int min, int max)
    {
        if (usedNumbers.Count >= max - min + 1)
        {
            return -1;
        }

        int number;

        do
        {
            number = Random.Range(min, max + 1);
        }
        while (usedNumbers.Contains(number));

        usedNumbers.Add(number);

        return number;
    }

    public static void ReiniciarNumeros()
    {
        usedNumbers.Clear();
    }
}
