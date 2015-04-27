using System;
namespace Registar.DomainModel
{
    /// <summary>
    /// DOMAIN MODEL - common del koj treba da go iskoristat DL i PL (vo delot M od MVC)
    /// </summary>
    public interface IBike
    {
        int BikeId { get; set; }
        string City { get; set; }
        string Colour { get; set; }
        object IgnoreMe { get; set; }
        string Model { get; set; }
        string Producer { get; set; }
        string RegNumber { get; set; }
        byte[] TimeStamp { get; set; }
    }
}
