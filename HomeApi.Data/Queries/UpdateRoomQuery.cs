using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public int Area { get; set; }
        public bool GasConnected { get; set; }
        public int Voltage { get; set; }
        public UpdateRoomQuery(int area = 0, bool gasConnected = false, int voltage = 0)
        {
            Area = area;
            GasConnected = gasConnected;
            Voltage = voltage;
        }
    }
}
