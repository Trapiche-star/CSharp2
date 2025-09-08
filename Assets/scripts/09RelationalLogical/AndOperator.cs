using UnityEngine;

public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] AndOperator
        /*Debug.Log(true && true);    // 둘다 참일경우 :참 
        Debug.Log(true && false);   // 둘중에 하나라도 거짓인 경우 : 거짓
        Debug.Log(false && true);   // 둘중에 하나라도 거짓인 경우 : 거짓
        Debug.Log(false && false);  // 둘자 거짓일 경우 : 거짓*/

        /*//[2]OrOperator(오어 연산자)
        Debug.Log(true || true);    // 둘다 참일 경우 : 참
        Debug.Log(true || false);   // 둘중에 하나라도 참인 경우 : 참
        Debug.Log(false || true);   // 둘중에 하나라도 참인 경우 : 참
        Debug.Log(false || false);   // 둘다 거짓인 경우: 거짓*/

        //[3]NotOperator
        Debug.Log(!true);   // 참을 부정
        Debug.Log(!false);  // 거짓을 부정


    }

    /*
    논리연산자(Logical Operator)
    [1] AndOperator(앤드 연산자): &&
    : (앞,뒤) 둘다 참일때만 참
    결과 - trye, false

    [2]OrOperator(오어 연산자) : ||
    :(앞,뒤)둘중에 하나라도 참이면 참

    [3]NotOperator (부정 연산자) : : !
    :참이면 거짓이되고, 거짓이면 참이 된다.


    */
}
