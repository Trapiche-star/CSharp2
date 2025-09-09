using System;
using UnityEngine;

public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* //[1] 초기식
         int n = 100;   // 마지막 숫자
         int i = 1;     // 시작값
         int sum = 0;   // 합계 저장 변수

         while (i <= n)
         {
             sum += i;  // 합계에 더하기
             i++;       // 다음 숫자로 증가
         }

         Debug.Log("1부터 " + n + "까지의 합 = " + sum);*/

        /*
        int sum = 0;
        int n = 100;
        int i = 1;

        while(i <= n)
        {
            sum = sum + i;
        }
        Debug.Log("1부터 " + n + "까지의 합 = " + sum);
        */

        int n = 100;
        int sum = 0;        
        int i = 1;

        while (i <= n)
        {
            if(i % 2 == 0)
            sum = sum + i;

            i++;
        }
        Debug.Log($"1부터 + {n} 까지 정수 중 짝수의 합:{sum}");



    }


}
/*
[Q]
while문을 이용해서 1부터 100(n)까지의 합을 구하는 프로그램 구현
 
*/