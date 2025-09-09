using UnityEngine;


//[Q]DoWhile 문을 이용해서 1부터 100까지의 정수중 홀수들의 합을 구하는 프로그램 구현

public class doWhilesum : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; //합을 저장하는 변수

        // 1 초기식
        int i = 1;

        do
        {
            //반복 실행문
            if( i % 2 != 0)
            {
                sum = sum + i;

            }


            // 2 증감식
            i++;
        } while (i < n); //3 조건식

        Debug.Log(sum);





        /*
        int i = 1;       // 시작값 (홀수부터 시작)
        int sum = 0;     // 합계를 저장할 변수

        do
        {
            if (i % 2 == 1)   // 홀수인지 판별
            {
                sum += i;     // 합계에 더하기
            }

            i++; // 증감식
        } while (i <= 100); // 100까지 반복

        Debug.Log("1부터 100까지 홀수들의 합 = " + sum);
        */




    }
    
}
