namespace Kinoafisha.DataAccess.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public int EntityId { get; set; }
        public virtual Entity Entity { get; set; }

        public int EntityRecordId { get; set; }

    }
}
