using UnityEngine;
using System;
public class NumberDifference : MonoBehaviour
{

    public int first = 0;
    public int second = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        // 두수의 차이를 저장하는 변수
        int diff = 0;
        //두수의 차이를 구하는식
        diff = first - second;
        diff = second - first;
        if (first >= second)
        {
            diff = first - second; // 퍼스트가 세컨드보다 클때
        }
        else
        {
            diff = second - first;
        }
        

        // 3. 출력
        Debug.Log($"{first}과 {second} 차이는 {diff}이다");


    }
   /* [Q]
    두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하세요

    [output]
   {first}과 {second} 차이는 {diff}이다


   
    */

      
   
}
