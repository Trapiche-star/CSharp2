using System;
using UnityEngine;
//using System


public class DataTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]현재 시간 출력 : DataTime 구조체 이용
        Debug.Log($"현재시간: {System.DateTime.Now}");

        //[2]년, 월, 일, 시, 분, 초
        Debug.Log($"현재시간:{System.DateTime.Now.Year}");
        Debug.Log($"{DateTime.Now.Month}월");
        Debug.Log($"{DateTime.Now.Day}일");
        Debug.Log($"{DateTime.Now.Hour}시");
        Debug.Log($"{DateTime.Now.Minute}분");
        Debug.Log($"{DateTime.Now.Second}초");







    }

    
}
