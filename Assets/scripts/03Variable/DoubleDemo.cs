
using Unity.VisualScripting;
using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수[1] 변수 선언 및 초기화
        float f = 3.14f;  //프론트는 f를 붙여야한다
        double d = 3.14D; //더블형은 d를 붙여도 되고 안붙여도 된다.
        decimal m = 3.14m;

        float min = float.MinValue; 
        float Max = float.MaxValue;

        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);

        Debug.Log(min);
        Debug.Log(Max);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
실수형 데이터 형식
근사값을 물어보지 않는다. 같냐라고 묻지 않는다. 크냐 작냐로 판단
Float(프론트)   : 32비트 부동 소수점 숫자
Double(더블)    : 64비트       "
Decimal(데시말) :120비트       "




 */
