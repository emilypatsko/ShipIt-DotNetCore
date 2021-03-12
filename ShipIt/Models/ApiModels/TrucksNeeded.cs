namespace ShipIt.Models.ApiModels
{
    public class TrucksNeeded
    {
        public int trucksNeeded { get; set; }

        //Empty constructor required for xml serialization.
        public TrucksNeeded()
        {
        }
    }
}