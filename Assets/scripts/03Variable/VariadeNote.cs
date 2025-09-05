using UnityEngine;

// 변수(Variable) :프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇(데이터를 저장하는 메모리 공간)
public class VariadeNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기(선언)
        int i; // i 이름으로 (정수형) 변수 만들기 (변수를 만들고 이름을 i라고 짓겠다.)

        //[2]변수에 값을 저장하기(대입,할당,초기화)
        i = 1234; // i라는 변수에 1234라는 값을 넣겠다.

        //[3]변수에 들어있는 값을 사용하기(참조)
        Debug.Log(i); // i라는 변수에 들어있는 값을 출력하라
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
