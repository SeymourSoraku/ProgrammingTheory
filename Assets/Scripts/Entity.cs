using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{
    protected int MaxHP { get { return _maxHp; } set { _maxHp = Mathf.Max(value, 1); } }
    int _maxHp;
    protected int HP { get { return _hp; } set { _hp = Mathf.Clamp(value, 0, _maxHp); } }
    int _hp;

    public void AlterHP(int value)
    {
        HP += value;
    }

}
