using Craft.Net.Data.Blocks;

namespace Craft.Net.Data.Items
{
    
    public class StringItem : Item
    {
        public override short Id
        {
            get
            {
                return 287;
            }
        }

        public override void OnItemUsedOnBlock(World world, Vector3 clickedBlock, Vector3 clickedSide, Vector3 cursorPosition, Entities.Entity usedBy)
        {
            if (world.GetBlock(clickedBlock + clickedSide) == 0)
                world.SetBlock(clickedSide + clickedSide, new TripwireBlock());
        }
    }
}