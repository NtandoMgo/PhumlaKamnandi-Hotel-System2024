using PhumlaKamnandi2024.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class RoomController
    {
        #region Data Members
        private RoomBD roomDB;
        private Collection<Room> rooms;
        #endregion

        #region Properties
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomController()
        {
            roomDB = new RoomBD();
            rooms = roomDB.AllRooms;
        }

        #endregion

        #region Database Communication.
        public void DataMaintenance(Room aRoom, PhumlaKamnandiDB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            roomDB.DataSetChange(aRoom, operation);
            //perform operations on the collection
            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    rooms.Add(aRoom);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    index = FindIndex(aRoom);
                    rooms[index] = aRoom;  // replace room at this index with the updated room
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    index = FindIndex(aRoom);  // find the index of the specific room in collection
                    rooms.RemoveAt(index);  // remove that room from the collection
                    break;

            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges()
        {
            //***call the roomDB method that will commit the changes to the database
            return roomDB.UpdateDataSource();
        }
        #endregion

        #region Searching through a collection

        //This method receives a room number as a parameter; finds the booking object in the collection of guests and then returns this object
        public Room Find(String roomNum)
        {
            int index = 0;
            bool found = (rooms[index].RoomNum == roomNum);
            int count = rooms.Count;
            while (!(found) && (index < rooms.Count - 1))
            {
                index = index + 1;
                found = (rooms[index].RoomNum == roomNum); 
            }
            return rooms[index];
        }

        public int FindIndex(Room aRoom)
        {
            int counter = 0;
            bool found = false;
            found = (aRoom.RoomNum == rooms[counter].RoomNum);  
            while (!(found) & counter < rooms.Count - 1)
            {
                counter += 1;
                found = (aRoom.RoomNum == rooms[counter].RoomNum);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
