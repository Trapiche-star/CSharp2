using UnityEngine;

public class ForTriangle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* for (int i = 1; i <= 5; i++)
         {
             //반복 실행문
             for (int j = 1; j <= 5; j++)
             {
                 //반복 실행문
                 Debug.Log($"i:{i}, j:{j}");
             }
         }*/

        // 1
        // 1,2
        // 1,2,3
        // 1,2,3
        // 1,2,3,4
        // 1,2,3,4,5

        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            for (int j = 1; j <= i; j++)
            {
                //반복 실행문
                Debug.Log("*");
            }
            Debug.Log("================================");
        }



    }


}
/*
이중 for문 -3중까진 어떻게든 쓰지만 4중 포문까진 절대로 피할것
for(int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        //반복실행문
    }
}

*
**
***
****
*****


 
*/