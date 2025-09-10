using UnityEngine;

public class ArraySum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 배열 요소들의 모든 값의 총합을 구하는 프로그램
        float[] arr = { 10.5f, 20.1f, 30.3f }; // 배열 초기화

        //합을 저장하는 변수 선언
        float sum = 0;

        Debug.Log($"배열의 길이:{arr.Length}");

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i]; // sum = sum + arr[i];
        }

        Debug.Log($"총합은 {sum}"); // 60.9 출력



        /*float sum = 0f; // 합계 변수

        // 배열 요소 반복해서 합계 계산
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Debug.Log("배열 요소들의 총합: " + sum);
            */
    }
}