using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfHotelService
{
    [DataContract]
    public class HotelModel
    {
        [DataMember]
        public int HotelID { get; set; }
        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string HotelAddress { get; set; }
        [DataMember]
        public double HotelRating { get; set; }
    }
}
