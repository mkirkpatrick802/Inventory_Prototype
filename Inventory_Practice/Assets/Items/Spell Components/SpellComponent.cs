using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpellComponent", menuName = "Items/Spell Component", order = 2)]
public class SpellComponent : Item
{
    [Header("Spell Component Settings")]
    public int price;           //Amount of gold its worth
    public int cost;            //Amount of gold it costs
    public bool isStackable;    //If item is stackable
    public int amount;          //Amount in stack
}
