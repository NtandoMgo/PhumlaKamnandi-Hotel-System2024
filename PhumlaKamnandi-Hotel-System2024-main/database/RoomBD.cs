using PhumlaKamnandi2024.business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi2024.database
{
    public class RoomBD : PhumlaKamnandiDB
    {
        #region Data Members
        private string table3 = "Room";
        private string sqlLocal3 = "SELECT * FROM Room";
        private Collection<Room> rooms;
        #endregion

        #region Property Method
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomBD() : base()
        {
            rooms = new Collection<Room>();

            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);
            
        }
        #endregion

        #region Utility Methods
        
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Room room;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    room = new Room();

                    room.RoomNum = Convert.ToString(myRow["RoomNum"]);
                    rooms.Add(room);
                }
            }
        }

        private void FillRow(DataRow aRow, Room aRoom, PhumlaKamnandiDB.DBOperation operation)
        {
            if (operation == PhumlaKamnandiDB.DBOperation.Add)
            {
                aRow["RoomNum"] = aRoom.RoomNum;
            }
        }

        private int FindRow(Room aRoom, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aRoom.RoomNum == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["RoomNum"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Data Operations CRUD
        public void DataSetChange(Room aRoom, PhumlaKamnandiDB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table3;

            switch (operation)
            {
                case PhumlaKamnandiDB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aRoom, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case PhumlaKamnandiDB.DBOperation.Update:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aRoom, dataTable)];
                    FillRow(aRow, aRoom, operation);
                    break;
                case PhumlaKamnandiDB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aRoom, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNum", SqlDbType.Int, 10, "RoomNum");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNum", SqlDbType.Int, 15, "RoomNum");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        private void Create_UPDATE_Command()
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Room SET RoomNum = @RoomNum " + "WHERE RoomNum = @RoomNum", cnMain);
            Build_UPDATE_Parameters();
        }

        //update data source
        public bool UpdateDataSource()
        {
            bool success = true;

            Create_UPDATE_Command();

            success = UpdateDataSource(sqlLocal3, table3);
            return success;
        }
        #endregion
    }
}
