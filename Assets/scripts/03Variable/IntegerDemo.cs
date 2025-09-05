using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;
        int max = int.MaxValue;

        Debug.Log("int 최소값: " + min);
        Debug.Log("int 최소값: " + max);

    }

    /*
    정수형(Integer)

    Scrinedinteger (+, -)부호가 있는 정수형 데이터 형식
    sbyte :  8bit (s바이트라고 읽음) -128 ~ 127
    short : 16bit -32,768 ~ 32,767
    int   : 32bit -2147483648 ~ 2147483647 (21억~ +21억
    long  : 64bit -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 (-9경 ~ +9경)

    1 Byte : 8비트

    UnScrinedinteger (+, -)부호가 없는 정수형 데이터 형식
    byte    :  8bit - 0~255
    Ushort  : 16bit - 0 65535
    Uint    : 32bit - 0 ~ + 4294967295 (0 ~ +42억)
    Ulong   : 64bit -








     */


    // Update is called once per frame
    void Update()
    {
        
    }
}
