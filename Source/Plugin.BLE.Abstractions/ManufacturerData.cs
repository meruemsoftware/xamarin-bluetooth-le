namespace Plugin.BLE.Abstractions
{
    public struct ManufacturerData
    {
        public int Id { get; }
        public byte[] Data { get; }

        public ManufacturerData(int id, byte[] data)
        {
            Id = id;
            Data = data;
        }
    }
}