using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3행 3열 2차원 배열을 만들고
        int[,] intArray = new int[3,3];

        //행과 열이 같으면 1, 행과 영리 틀리면 0으로 초기화
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                if (i == j)
                {
                    intArray[i, j] = 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }

                // 출력
                Debug.Log($"intArray[{i},{j}] = {intArray[i, j]}");
            }



            /* 챗 지피티

            //[1] 3행짜리 가변 배열 선언
            int[][] intArray = new int[3][];

            //[2] 각 행마다 3열짜리 배열 생성
            for (int i = 0; i < 3; i++)
            {
                intArray[i] = new int[3];
            }

            //[3] 값 초기화 (행 == 열 → 1, 아니면 0)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        intArray[i][j] = 1;
                    }
                    else
                    {
                        intArray[i][j] = 0;
                    }

                    Debug.Log($"intArray[{i}][{j}] = {intArray[i][j]}");
                }
                Debug.Log("=====================");        
             */



        }
    }

   
}

/*
[Q]
3행 3열의 2차원 배열을 만들고 아래와 같이 초기화 해주세요
[3.3]

행과 열이 같으면 1, 행과 열이 틀리면 0으로 초기화

1, 0, 0
0, 1, 0
0, 0, 1



*/