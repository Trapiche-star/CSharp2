using UnityEngine;

//[1] enum 정의, 선언
//enum의 값을 정수형, 문자열로 사용이 가능 
//동물들을 구분하는 열거형
enum Animals
{
    Rabbit,
    Dragon,
    Snake
}
enum Animale
{
    Horss,
    Sheep = 5,
    Monkey
}





public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] enum 사용 -enum 변수 선언하고 초기화
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        
        Debug.Log($"Animals.Dragon:{num}, {str}");
     


    }

  
}
