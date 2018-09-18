using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfHotelService
{
    public class HotelData
    {
        public List<HotelModel> Data;// = new List<HotelModel>();
        public HotelData()
        {
            Data = new List<HotelModel>();
            //Data.AddRange(GenerateDemoData());
            Data.Add(new HotelModel { HotelID = 1, HotelName = "Hyaat", HotelAddress = "Viman Nagar Pune", HotelRating = 5 });
            Data.Add(new HotelModel { HotelID = 2, HotelName = "Novotal", HotelAddress = "Viman Nagar Pune", HotelRating = 4 });
        }

        //private List<HotelModel> GenerateDemoData()
        //{
        //    List<HotelModel> list = new List<HotelModel>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        HotelModel model = new HotelModel();
        //        model.HotelID = i;
        //        model.HotelName = string.Format("Hyaat{0}", i);
        //        model.HotelRating = i;
        //        model.HotelAddress = "Pune";
        //        list.Add(model);
        //    }
        //    return list;
        //}
    }
}
