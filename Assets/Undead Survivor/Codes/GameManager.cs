using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���������� �ٷ� �ٸ� ���Ͽ��� ��밡��! ���� ���� ����?
    public static GameManager instance;
    public Player player;

    void Awake()
    {
        instance = this; //this -> �ڱ��ڽ� ���� �Ҵ�
    }
}
