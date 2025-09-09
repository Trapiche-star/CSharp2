using UnityEngine;

public class doWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        for (int i = 0; i < 3; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요");
        }


        //[1] 초기식
        int i = 0;
        while(i < 3) //[2]조건식
        {
            // 반복 실행문
            Debug.Log("안녕하세요");

            //[3]증감식
            i++;
        }
        */

        //[1]초기식
        int i = 0;
        do
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;


        } while (i < 3 ); //[3]조건식

        /*

        //초기식 i=0 -> 출력 -> i:1 -> i<3(참) -> 출력 -> i:2
        // -> i<3(참)-> 출력 -> i:3 -> i<3(거짓) -> while문  종료 


        int i = 4; //초기식
        while (i < 3) // 조건식 참이면 반복문 실행 거짓이면 while문 종료
        {
            //반복 실행문
            Debug.Log("안녕하세요");


            //증감식
            i++;        //1 -> 2 -> 3
        }

        // i=4 -> i<3 -> while문  종료 
        */


    }


}

/*
// 반복 실행문을 실행
// 조건식 판별하여 참이면 반복 실행문 실행
// 거짓이면 while문 종료

do
{
    //반복 실행문

}while (조건식

 
*/
