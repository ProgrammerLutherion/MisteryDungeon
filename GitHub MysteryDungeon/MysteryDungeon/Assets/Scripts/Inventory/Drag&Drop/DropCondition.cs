public abstract class DropCondition
{
	public abstract bool Check(DraggableComponent draggable);

	public abstract bool Check(DraggableComponent draggable,EquipmentPart isPart);
}
