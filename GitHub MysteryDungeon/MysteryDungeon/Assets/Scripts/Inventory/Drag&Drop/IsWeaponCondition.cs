public class IsWeaponCondition : DropCondition
{
	public override bool Check(DraggableComponent draggable,EquipmentPart isPart)
	{
		var item = draggable.GetComponentInParent<EquipmentSlot>().holdingItem;
		return item != null && item.equipmenttype == isPart;
	}

    public override bool Check(DraggableComponent draggable)
    {
        throw new System.NotImplementedException();
    }
}
