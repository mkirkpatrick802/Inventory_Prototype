using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _playerInventory;

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }

    public void SetInventoryUI(Inventory playerInventory)
    {
        _playerInventory = playerInventory;
    }
}
