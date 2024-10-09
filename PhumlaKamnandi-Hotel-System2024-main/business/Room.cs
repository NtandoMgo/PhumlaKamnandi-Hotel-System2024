using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class Room
    {
        #region Data Members
        private string roomNum;
        #endregion

        #region Properties
        public string RoomNum { get { return roomNum; } set { roomNum = value; } }
        #endregion

        #region Constructor
        public Room()
        {
            RoomNum = string.Empty;
        }
        public Room(string RoomNum)
        {
            this.roomNum = RoomNum;
        }
        #endregion
    }
}
