using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Basic")]
    public int health;
    public int defense;
    public float movementSpeed;

    [Header("Combat")]
    public int attack;
    public float attackRange;
    public float attackSpeed;

    [Header("Magic")]
    public int magicResistance;
    public bool hasMagic;
    public int mana;
    public enum MagicElementType { Fire, Water, Earth, Air };
    public MagicElementType magicType;
    public int magicDamage;
}
