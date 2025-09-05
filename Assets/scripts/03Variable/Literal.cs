using UnityEngine;

//값(Literal)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기(선언)
        int num;    //정수형 변수
        double su;  //실수형 변수
        bool flag;  //부울(논리)형 변수
        string str; //문자열 변수
        char c;    //문자형 변수

        //[2] 변수에 값 저장
        num = 1234;
        su = 3.14159;
        flag = true; //true(참), false(펄스-거짓)
        str = "안녕하세요"; // 큰따옴표로 묶음- 큰따옴표는 문자열
        c = 'a'; //작은다음표는 문자형 - 한글자식만 들어간다

        //[3] 변수 사용하기
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
