using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 정적변수는 바로 다른 파일에서 사용가능! 절차 지향 장점?
    public static GameManager instance;
    public Player player;

    void Awake()
    {
        instance = this; //this -> 자기자신 정적 할당
    }
}
