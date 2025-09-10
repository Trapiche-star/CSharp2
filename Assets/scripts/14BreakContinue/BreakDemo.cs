
using UnityEngine;

public class BreakDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        int i = 1;      // 시작 값
        int sum = 0;    // 합계 저장 변수

        while (i <= 10 && sum < 22)
        {
            sum += i;   // i를 sum에 더하기
            i++;        // 다음 수로 이동
        }

        //Debug.Log("합계: " + sum);        
        */
        /*
        int i = 1;      // 시작 값
        int sum = 0;    // 합계 저장 변수

        while (i <= 10)
        {
            sum += i;   // i를 sum에 더하기
            Debug.Log("현재 합계: " + sum);

            if (sum >= 22) // 22 이상이면 멈춤
            {
                break;
            }

            i++;        // 다음 수로 이동
        }        
        */

        int sum = 0;

        int i = 1;

        while (i <= 10)
        {
            sum = sum + i;

            if(sum >= 22)
            {
                break;
            }
            
            i++;
        }
        Debug.Log(sum);

    }

    
}
/*
[Q]
1부터 10까지의 정수의 합(sum)을 구하는 프로그램 구현
합(sum) 이 22 이상이 되면 더이상 합을 구하지 않는다.
while문 이용해서 sum 출력


 
*/