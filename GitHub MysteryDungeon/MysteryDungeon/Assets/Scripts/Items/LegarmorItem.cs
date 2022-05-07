using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/LegarmorItem")]
public class LegarmorItem : ItemObject
{
    [SerializeField] private int ArmorValue;
    private void Awake()
    {
        type = ItemType.Armor;
        equipmenttype = EquipmentPart.LegArmor;
    }
}
