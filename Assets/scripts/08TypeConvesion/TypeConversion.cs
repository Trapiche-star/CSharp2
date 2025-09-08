using UnityEngine;


// 형식 변환(Type Conversion)
public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //d를 double형 변수로 선언하고 12.34를 저장
        double d = 12.34; //64bit 실수형

        //i를 int형 변수로 선언하고 1234를 저장
        int i = 1234;   //32bit 정수형

        //[1]묵시적(암묵적,암시적)형식 변환: dooble -> int (큰 그릇 -> 작은 그릇)
        d = i; // (타입이 달라도 큰 그릇에 작은 그릇을 넣는 것은 자동 형변환이 된다)
        d = (double)i; //명시적 형식 변환 (큰 그릇에 작은 그릇을 넣는 것은 자동 형변환이 된다)

        Debug.Log($"암시적 형식변환: {d}");

        d = 12.34;
        i = 1234;

        //[2]명시적 형식 변환: int <- double (작은 그릇 <- 큰 그릇)
        //i = d; //오류 발생 (타입이 달라도 작은 그릇에 큰 그릇을 넣는 것은 자동 형변환이 안된다)
        i = (int)d; //명시적 형식 변환 이렇게 선언하면 작은 그릇에 큰 그릇을 넣을 수
        Debug.Log($"명시적 형식변환: {i}");

        //[3]수 이외 형식간 변환
        string s = ""; //한글자도 되고 여러글자도 되고 글이 없어도 된다. ""'이렇게하면 빈값으로 초기화 가능
        // s = d;  //오류 발생 (string과 double은 서로 다른 형식이므로 자동 형변환이 안된다)
        s = d.ToString(); //명시적 형식 변환
        Debug.Log($"형식변환: {s}");




    }


}
