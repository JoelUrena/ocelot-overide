#if PLY_GAME

using plyBloxKit;
using UnityEngine;

namespace Devdog.InventoryPro.Integration.plyGame.plyBlox
{
    [plyBlock("Inventory Pro", "Items - Instance", "Get instance item category id", BlockType.Variable, Order = 4, ShowName = "Get instance item category id",
        ReturnValueString = "Return - Int (id)", ReturnValueType = typeof(Int_Value),
        CustomStyle = "plyBlox_VarYellowDark", Description = "Returns the given item's category id.")]
    public class GetInstanceItemCategoryID : Int_Value
    {
        [plyBlockField("Item", ShowName = true, ShowValue = true, DefaultObject = typeof(SystemObject_Value), EmptyValueName = "-error-", SubName = "InventorySystem item", Description = "The item we wish to get the category ID of.")]
        public SystemObject_Value item;

        public override void Created()
        {
            blockIsValid = (item != null);
            
            if(blockIsValid == false)
                Log(LogType.Error, "Item has to be set.");
        }

        public override BlockReturn Run(BlockReturn param)
        {
            var i = item.RunAndGetSystemObject() as InventoryItemBase;
            if (i != null)
            {
                value = (int)i.category.ID;
                return BlockReturn.OK;
            }

            Log(LogType.Error, "Object is not an Inventory Pro item.");
            return BlockReturn.Error;
        }
    }
}

#endif