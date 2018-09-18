using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfHotelService
{
    [DataContract]

    class HotelService : IHotelOperations
    {
        HotelData data = new HotelData();
        public List<HotelModel> GetAllHotel()
        {
            return data.Data;
        }

        public string GetHotelByID(int id)
        {
            for(int i = 0; i < data.Data.Count; i++)
            {
                if (data.Data[i].HotelID == id)
                {
                    return string.Format("Hotel Name: {0} and Hotel Address: {1}", data.Data[i].HotelName, data.Data[i].HotelAddress);
                }
            }
            return null;
        }
    }
}
