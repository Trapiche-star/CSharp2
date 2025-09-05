using UnityEngine;


//숫자 이외의 데이터 형식: bool, char, string
//char(캐릭터) : 문자형, 단일 문자 저장
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]char형 변수 선언 및 초기화
        char grade = 'A'; //작은 따옴표로 감싼다.
        char kor = '한'; //한글 문자도 저장 가능

        //[2] 사용하기 

        Debug.Log("grade: " + grade);
        Debug.Log("kor: " + kor);


    }

    
    
}
