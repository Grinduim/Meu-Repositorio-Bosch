using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelaria
{
    public class SistemaDeReserva
    {
        public int Room;
        public DateTime CheckIn;
        public DateTime CheckOut;
        public int TotalDays;

        public SistemaDeReserva(DateTime CheckIn, DateTime CheckOut, int Room)
        {
            SetRoom(Room);
            SetCheckIn(CheckIn);
            SetCheckOut(CheckOut);
            SetTotalDay();
        }

        public void ChangeReservation(DateTime CheckIn, DateTime CheckOut)
        {
            SetCheckIn(CheckIn);
            SetCheckOut(CheckOut);
            SetTotalDay();
        }

        public void SetRoom(int NewRoom)
        {
            this.Room = NewRoom;
        }

        public void SetCheckIn(DateTime CheckIn)
        {
            this.CheckIn = CheckIn;
        }

        public void SetCheckOut(DateTime CheckOut)
        {
            this.CheckOut = CheckOut;
        }

        public void SetTotalDay()
        {
            this.TotalDays = int.Parse(CheckOut.Subtract(CheckIn).ToString("dd"));
        }

    }
}
