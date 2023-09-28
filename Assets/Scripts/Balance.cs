using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [HideInInspector]
    public int hp;
    public int power;
    public int type;

    void Start()
    {
        this.hp = 0;
        this.power = 0;
        this.type = 0;
    }

    void Update()
    {

    }
}
