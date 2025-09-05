using UnityEngine;


//불(bool) 데이터 타입:논리 자료형, 참/거짓, true/false
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]bool형 변수 선언 및 초기화
        bool bln = true;
        bool isOut = false;


        //[2]사용하기
        Debug.Log("bln: " + bln);
        Debug.Log("isOut: " + isOut);

    }


}
