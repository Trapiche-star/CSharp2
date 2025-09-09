using UnityEngine;

public class ForNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 증가한 값을 출력한다 : 5번 반복
        //Count:1, Count:2, Count:3, Count:4, Count:5, 
        /*for(int i=0; i<5; i++)    //5번 반복 실행 -1방법 < 이방법이 제일깔금하다
        {
            Debug.Log($"Count: {i+1}"); // {i} 이렇게하면 0부터 출력해버린다 그래서 +1을 붙여준다.
        }*/

        /*for (int i=1; i<6; i++)   //5번 반복 실행  -2방법
        {
            Debug.Log($"Count: {i}"); 
        }*/

        /*for (int i=0; i <= 5; i++)  //5번 반복  실행 -3방법
        {
            Debug.Log($"Count: {i}");
        }*/

        for (int i=0; i<5; i = i + 2)
        {
            Debug.Log($"Count: {i}");
        }


    }


}
