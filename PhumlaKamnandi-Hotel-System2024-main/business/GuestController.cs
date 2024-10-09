using PhumlaKamnandi2024.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.business
{
    public class GuestController
    {
        #region Data Members
        private GuestDB guestDB;
        private Collection<Guest> guests;
        #endregion

        #region Property Methods
        public Collection<Guest> AllGuests { get { return guests; } }
        #endregion

        #region Constructor
        public GuestController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        #endregion

        #region Database Communication
        //public Guest RecordGuest(Guest guest)
        //{
        //    guestDB = new GuestDB();
        //    guests = guestDB.AllGuests;

        //    if (string.IsNullOrEmpty(guest.ID))
        //    {
        //        guestDB.DataSetChange(guest, PhumlaKamnandiDB.DBOperation.Add);
        //        guestDB.InsertGuestDataSource(guest);
        //    }
        //    else
        //    {
        //        guestDB.DataSetChange(guest, PhumlaKamnandiDB.DBOperation.Update);
        //        guestDB.UpdateGuestDataSource(guest);
        //    }

        //    guestDB.RetrieveAllGuests();
        //    guests = guestDB.AllGuests;

        //    // Use GuestID for retrieval
        //    guest = guests.FirstOrDefault(x => x.ID == guest.ID);

        //    return guest;
        //}

        public void DataMaintenance(Guest aGuest, PhumlaKamnandiDB.DBOperation operation)
        {
            int index = 0;
            guestDB.DataSetChange(aGuest, operation);
            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    guests.Add(aGuest);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    index = FindIndex(aGuest);
                    guests[index] = aGuest;  // replace guest at this index with the updated guest
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    index = FindIndex(aGuest); 
                    guests.RemoveAt(index);
                    break;
            }
        }
        public bool FinalizeChanges(Guest guest)
        {
            //***call the BookingDB method that will commit the changes to the database
            return guestDB.UpdateDataSource(guest);
        }
        #endregion

        #region Searching Methods
        public Guest Find(string gID)
        {
            GuestDB guestDB = new GuestDB();
            guests = guestDB.AllGuests;
            Guest foundGuest = null;
            if (guests.Any(x => x.ID == gID))
            {
                foundGuest = guests.First(x => x.ID == gID);
            }
            return foundGuest;
        }
        public int FindIndex(Guest aGuest)
        {
            int index = 0;
            bool found = false;
            found = (aGuest.ID == guests[index].ID);
            while (!(found) & index < guests.Count - 1)
            {
                index += 1;
                found = (aGuest.ID == guests[index].ID);
            }
            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
