using UnityEngine;

//string(문자열) : 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1]string형 변수 선언 및 초기화
        string name = "홍길동";
        string muliLine = @"
            안녕하세요
            반갑습니다
         ";

        //[2] 사용하기
        Debug.Log("안녕하세요 " + name + "입니다");
        Debug.Log(muliLine);
        */

        //문자열 보간법 string interpolation (스트링인터포레이션)
        string message = "문자열 보간법";
        string msg = string.Format("{0}님 {1}", "홍길동",  "안녕하세요");

        Debug.Log("Message : " + message); // 문자열 더하기 연산 이것과 아래것 결과 값은 같다.어느것을 사용하든 성향차이
        Debug.Log($"message: {message}"); //달러표시는 문자열 보간법을 하겠다는 의미
        Debug.Log(msg);






    }


}
