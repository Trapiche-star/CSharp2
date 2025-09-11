using UnityEngine;

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4!
        Debug.Log(4 * 3 * 2 * 1);

        // 재귀 호출로 팩토리얼 구하기
        Debug.Log(FactorialRecursive(4));

        // for문으로 팩토리얼 구하기
        Debug.Log(FactorialFor(4));

        // 삼항 연산자로 재귀 팩토리얼 구하기
        Debug.Log(FactorialTernary(4));
    }

    // 재귀 호출로 팩토리얼 구하는 함수
    int FactorialRecursive(int n)
    {
        if (n <= 1) // 종료 조건
            return 1;
        return n * FactorialRecursive(n - 1); // 재귀 호출
    }

    // for문 사용
    int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i; // 곱셈
        }
        return result;
    }

    // 3항 연산자를 이용한 재귀 팩토리얼
    int FactorialTernary(int n)
    {
        return (n <= 1) ? 1 : n * FactorialTernary(n - 1);
    }

}







/*
팩토리얼 구하는 알고리즘 구현
Factorial(팩토리얼)  (!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3     = 3 * 2!      
4! = 1 * 2 * 3 * 4 = 4 * 3!
.....등등

n! = 1 * 2 * 3 * .... * (n-1) * n
n! = n * (n-1) * (n-2) * .... 2 * 1
   = n * ((n-1) * (n-2) * .... 2 * 1);
   = n * (n-1)!
 
*/





/*
재귀함수
재귀호출 : 함수가 자신의 코드블록 안에서 자기 자신을 다시 호출
재귀함수는 매개변수를 가지고 있다
매개변수는 감산, 가산이 된다
재귀함수의 코드 블록안에는 종료할 수 있는 조건이 필요하다

- 종료 조건 처리부 
- 재귀 호출부

*/
