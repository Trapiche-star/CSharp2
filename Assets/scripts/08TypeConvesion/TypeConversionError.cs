using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* //[1] long 형식 변수 선언하고 가장 큰 수를 저장
      long l = long.MaxValue;
      Debug.Log($"l의 값: {l}");

      //2 int 형식의 변수에 i값을 저장
      int i = (int)1;
      Debug.Log($"i의 값: {i}");*/

        // -21억~ 21억까지 저장하는 그릇 int
        int x = 255;

        //0~255까지 저장하는 그릇 byte
        byte y = (byte)x;
        Debug.Log(x + "-> " + y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
