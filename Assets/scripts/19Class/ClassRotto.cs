using UnityEngine;

public class ClassRotto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[] numbers = new int[6]; // 6개 번호 저장
        int count = 0;

        // 중복 없는 6개 숫자 생성
        while (count < 6)
        {
            int num = Random.Range(1, 46); // 1~45 랜덤
            bool exists = false;

            // 이미 있는지 배열 검사
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] == num)
                {
                    exists = true;
                    break;
                }
            }

            // 중복이 없으면 배열에 저장
            if (!exists)
            {
                numbers[count] = num;
                count++;
            }
        }

        string output = "번호: ";
        for (int i = 0; i < numbers.Length; i++)
        {
            output += numbers[i] + " ";
        }

        Debug.Log(output);
        // 예: 번호: 5 12 23 34 41 7
    }
}

  


/*
//로또번호 생성기
[1] 6개 번호
[2] 1~45번 사이의 랜덤번호
[3] 중복된 숫자가 나오면 안된다

//
[1], [2] 구현
1) 임의의 정수형 변수 (숫자) 6개 번호 출력
2) 임의의 정수형 변수에 1~45 랜덤값 저장
3) 중복 제거


 
*/
