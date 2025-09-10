using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 1000;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // 1부터 n(100)까지의 정수의 합
        // 3의 배수를 합에서 제외
        int sum = 0;

        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0)
                continue;
            
            //sum = sum + i; 
            sum += i; // 위에것의 누적식
        }
        Debug.Log(sum);

        
        
        /*int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0) // 3의 배수는 제외
            {
                continue;   // 아래 코드 건너뛰고 다음 반복
            }

            sum += i;       // 합계에 더하기
        }

        Debug.Log("1~100까지 3의 배수를 제외한 합: " + sum);*/
    }
}  

/*
[Q]
1부터 100까지의 정수의 합을 구하는데 3의 배수를 제외하고 합을 구하세요
 
 
*/