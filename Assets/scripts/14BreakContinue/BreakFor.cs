using UnityEngine;


// Break; : 반복문(for,while) {} 을 빠져나오는 명령문
 //         반복문(for,while) {} 을 강제 종료시킨다
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //5번 반복하는 for문 작성- i가 2일대 for문 종료
        /* 
         for(int i = 0; i < 5; i++)
         {
             //반복 실행문 //반복 실행문 3번 실행
             Debug.Log(i);

             if(i == 2)
             {
                 break;
             }

         }
        */

        //5번 반복하는 for문 작성- i가 2일대 for문 종료
        for (int i = 0; i < 5; i++)
        {
            
            if (i == 2)
            {
                break;
            }
            Debug.Log(i);
        }
        //--> 명령문 아래로 두면 2번만 실행
    }

    //명령문 2

    // i= 0 -> i<5(참) -> 반복문 -> i:1 -> i<5(참) -> 반복문
    // -> i:2 -> i<5(참) -> 반복문 -> break; -> for문 종료 -> 명령문2


}
