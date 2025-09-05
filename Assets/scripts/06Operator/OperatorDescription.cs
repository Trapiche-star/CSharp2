
using UnityEngine;

//Operator(오퍼레이터) : 연산자 - + , -, *, /, % 등연산을 수행하는 키워드
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        /* Debug.Log(3 + 5);   // 8
         Debug.Log(5 - 3);   // 2
         Debug.Log(3 * 5);   // 15
         Debug.Log(5 / 3);   // 1 */ // 컨트롤+쉽프트+/ : 주석처리 단축키

        /*int value = 0;

        value = 8;      //value(벨류) 변수에 8을 저장
        value = +value; //
        Debug.Log(value); // 8

        value = -8;
        value = +value;
        Debug.Log(value); // -8

        value = 8;
        value = -value;
        Debug.Log(value); // -8

        value = -8;
        value = -value;
        Debug.Log(value); // 8*/

        int i = 5;
        int j = 3;
        int k;
        
        k = i + j;
        Debug.Log(k); // 8

        k = i - j;
        Debug.Log(k); // 2

        k = i * j;
        Debug.Log(k); // 15

        k = i / j;
        Debug.Log(k); // 1

        k = i % j;
        Debug.Log(k); // 2 나머지 연산자




    }

}

/*
단항 연산자 : +,-
이항 연산자 : +,-,*,/,%
삼항 연산자


정수와 실수를 연산하면 실수가 된다
정수와 정수를 연산하면 정수가 된다
문자열과 정수를 더하면 문자열이 된다

*/