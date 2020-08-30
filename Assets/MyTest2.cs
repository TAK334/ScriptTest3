using UnityEngine;
using System.Collections;

public class MyTest2 : MonoBehaviour
{
    void Start()

    {
        //要素数5を逆順に出力する
        int[] array = new int[5];


        array[0] = 50;
        array[1] = 10;
        array[2] = 20;
        array[3] = 30;
        array[4] = 40;
        for (int a = 4; a < 0; a++)
        {
            Debug.Log(array[a]);
        }

        for (int b = 4; b > -0; b--)
        {
            Debug.Log(array[b]);
        }

    }

    void Update()
    {

    }
}
