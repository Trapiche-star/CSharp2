using UnityEngine;

public class LogicalPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r  = false;

        r = (i == 3) && (j != 3);                      // true &&t true
        Debug.Log(r); //꾸미기 Debug.Log($"r:{r}");    // true

        r = (i != 3) || (j == 3);                      // false || false
        Debug.Log(r);               //  false

        r = (i >= 5);               // false

        Debug.Log($"!r {!r}");      //

        Debug.Log((1 == 1) || (1 != 1));    //

        Debug.Log(!(1 == 1));               //

    }

  
}
