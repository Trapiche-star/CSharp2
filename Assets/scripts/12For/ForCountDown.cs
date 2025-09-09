using UnityEngine;

public class ForCountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //11부터 5까지 CountDown 프로그램 구현
        for(int i = 1; i <= 5; i++)
        {
            Debug.Log($"증가 CountDown: {i}");
        }

        Debug.Log("=================================");

        //5부터 1까지 CountDown 프로그램 구현

        for (int i = 5; i >= 1; i--)
        {
            Debug.Log($"감소 CountDown: {i}");
        }

       /* //무한루프: 버그
        for(; ; )
        {
            Debug.Log("무한루프");
        }*/

    }


}
