using UnityEngine;


//[1]enum 선언, 정의
//우선 순위를 정의하는 열거형 생성
enum priorrity
{
    High,
    Normal,
    Low
}

public class EnumerationDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] enum 사용 - 변수 선언
        priorrity high = priorrity.High;
        priorrity Normal = priorrity.Normal;
        priorrity Low = priorrity.Low;

        //
        Debug.Log($"{high},{Normal},{Low}");



    }

    
}

/*
열거형 (Enumeration(이너미레이션), Enum(이넘))
: 하나의 이름으로 서로 관련 있는 정수 값을 갖는 상수들의 집합
: 사용자 정의 데이터 형식 

enum (enum 이름)
{
    상수명,
    상수명,
    ...
}
 

 
*/