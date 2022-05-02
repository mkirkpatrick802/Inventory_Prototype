using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpell", menuName = "Items/Spell", order = 1)]
public class Spell : Item
{
    [Header("Combat Settings")]
    public int damage;
    public float cooldown;
    public float duration;

    [Space(15)]
    public SpellComponent[] recipe;

    [Header("Spell Linking")]
    public BaseSpell prefab;
}
