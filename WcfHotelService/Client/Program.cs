using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.HotelServiceReference;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            HotelOperationsClient hotel= new HotelOperationsClient("BasicHttpBinding_IHotelOperations");
            while (true)
            {
                Console.WriteLine("----Hotel Operatioons-----");
                Console.WriteLine("1) Get All Hotel \n2) Get Hotel By ID \n3) Exit");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        {
                            List<HotelModel> Data = new List<HotelModel>(hotel.GetAllHotel());
                            for(int i = 0; i < Data.Count; i++)
                            {
                                Console.WriteLine("Hotel Name: {0} and Hotel Address: {1}", Data[i].HotelName, Data[i].HotelAddress);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter ID");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(hotel.GetHotelByID(id));
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }

            }
        }
    }
}
