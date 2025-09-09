using UnityEngine;

public class ForPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; // 합을 저장할 변수

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 4 == 0) // 3의 배수 또는 4의 배수인지 판별
            {
                sum += i; // 합에 더하기
            }




        }

        Debug.Log(sum);





    }

}

/*
[Q]
1부터 100까지의 정수 중에서 3의 배수 또는 4의 배수 들의 합을 구하는 프로그램 구현



*/