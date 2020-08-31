using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する

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

}