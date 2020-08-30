using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        //要素数5の逆順に出力する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 1;
        points[1] = 2;
        points[2] = 3;
        points[3] = 4;
        points[4] = 5;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


public class MyTest : MonoBehaviour
{
    void Start()

    {
        // 配列の要素をすべて表示する
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        // 配列の要素をすべて表示する
        for (int b = 0; b < 5; b--)
        {
            Debug.Log(array[b]);
        }

    }

    void Update()
    {

    }
}


