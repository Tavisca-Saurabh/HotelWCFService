using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfHotelService
{
    [ServiceContract]
    public interface IHotelOperations
    {
        [OperationContract]
        string GetHotelByID(int id);
        [OperationContract]
        List<HotelModel> GetAllHotel();
    }
}
