using UnityEngine;
using System.Collections;

public class MyTest2 : MonoBehaviour
{
    void Start()

    {
        // 配列の要素をすべて表示する
        //要素数5を逆順に出力する
        int[] array = new int[6];


        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        for (int a = 4; a < 0; a++)
        {
            Debug.Log(array[a]);
        }
        // 配列の要素をすべて表示する
        for  (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }

    }

    void Update()
    {

    }
}
