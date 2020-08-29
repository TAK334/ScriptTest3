using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        // 配列の要素をすべて表示する


    private static void NewMethod(int[] points)
    {
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

// Use this for initialization
Private private void Start()
{
    // 5回処理を繰り返す
    for (int i = 0; i < 5; i++)
    {
        Debug.Log(i);
    }
}


    

  




