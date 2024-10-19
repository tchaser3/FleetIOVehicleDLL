using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace FleetIOVehicleDLL
{
    public class FleetIOVehicleClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        FleetIOVehiclesDataSet aFleetIOVehiclesDataSet = new FleetIOVehiclesDataSet();
        FleetIOVehiclesDataSetTableAdapters.fleetiovehiclesTableAdapter aFleetIOVehiclesTableAdapter = new FleetIOVehiclesDataSetTableAdapters.fleetiovehiclesTableAdapter();

        InsertFleetIOVehicleEntryTableAdapters.QueriesTableAdapter aInsertFleetIOVehicleEntryTableAdapter;

        FindFleetIOVehicleDataSet aFindFleetIOVehicleDataSet;
        FindFleetIOVehicleDataSetTableAdapters.FindFleetIOVehicleTableAdapter aFindFleetIOVehicleTableAdapter;

        FindFleetIOVehicleByVehilceNumberDataSet aFindFleetIOVehicleByVehicleNumberDataSet;
        FindFleetIOVehicleByVehilceNumberDataSetTableAdapters.FindFleetIOVehicleByVehicleNumberTableAdapter aFindFleetIOVehicleByVehicleNumberTableAdapter;

        FindFleetIOVehiclesByGroupDataSet aFindFleetIOVehiclesByGroupDataSet;
        FindFleetIOVehiclesByGroupDataSetTableAdapters.FindFleetIOVehiclesByGroupTableAdapter aFindFleetIOVehiclesByGroupTableAdapter;

        FindFleetIOVehicleByTypeDataSet aFindFleetIOVehicleByTypeDataSet;
        FindFleetIOVehicleByTypeDataSetTableAdapters.FindFleetIOVehicleByTypeTableAdapter aFindFleetIOVehicleByTypeTableAdapter;

        FindSortedFleetIOVehiclesDataSet aFindSortedFleetIOVehiclesDataSet;
        FindSortedFleetIOVehiclesDataSetTableAdapters.FindSortedFleetIOVehiclesTableAdapter aFindSortedFleetIOVehiclesTableAdapter;

        public FindSortedFleetIOVehiclesDataSet FindSortedFleetIOVehicles()
        {
            try
            {
                aFindSortedFleetIOVehiclesDataSet = new FindSortedFleetIOVehiclesDataSet();
                aFindSortedFleetIOVehiclesTableAdapter = new FindSortedFleetIOVehiclesDataSetTableAdapters.FindSortedFleetIOVehiclesTableAdapter();
                aFindSortedFleetIOVehiclesTableAdapter.Fill(aFindSortedFleetIOVehiclesDataSet.FindSortedFleetIOVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Find Sorted Fleet IO Vehicles " + Ex.ToString());
            }

            return aFindSortedFleetIOVehiclesDataSet;
        }
        public FindFleetIOVehicleByTypeDataSet FindFleetIOVehicleByType(string strFleetIOVehicleType)
        {
            try
            {
                aFindFleetIOVehicleByTypeDataSet = new FindFleetIOVehicleByTypeDataSet();
                aFindFleetIOVehicleByTypeTableAdapter = new FindFleetIOVehicleByTypeDataSetTableAdapters.FindFleetIOVehicleByTypeTableAdapter();
                aFindFleetIOVehicleByTypeTableAdapter.Fill(aFindFleetIOVehicleByTypeDataSet.FindFleetIOVehicleByType, strFleetIOVehicleType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Find Fleet IO Vehicle By Type " + Ex.ToString());
            }

            return aFindFleetIOVehicleByTypeDataSet;
        }
        public FindFleetIOVehiclesByGroupDataSet FindFleetIOVehiclesByGroup(string strFleetIOVehicleGroup)
        {
            try
            {
                aFindFleetIOVehiclesByGroupDataSet = new FindFleetIOVehiclesByGroupDataSet();
                aFindFleetIOVehiclesByGroupTableAdapter = new FindFleetIOVehiclesByGroupDataSetTableAdapters.FindFleetIOVehiclesByGroupTableAdapter();
                aFindFleetIOVehiclesByGroupTableAdapter.Fill(aFindFleetIOVehiclesByGroupDataSet.FindFleetIOVehiclesByGroup, strFleetIOVehicleGroup);

            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Find Fleet IO Vehicle By Group " + Ex.ToString());
            }

            return aFindFleetIOVehiclesByGroupDataSet;
        }
        public FindFleetIOVehicleByVehilceNumberDataSet FindFleetIOVehicleByVehicleNumber(string strFleetIOVehicleNumber)
        {
            try
            {
                aFindFleetIOVehicleByVehicleNumberDataSet = new FindFleetIOVehicleByVehilceNumberDataSet();
                aFindFleetIOVehicleByVehicleNumberTableAdapter = new FindFleetIOVehicleByVehilceNumberDataSetTableAdapters.FindFleetIOVehicleByVehicleNumberTableAdapter();
                aFindFleetIOVehicleByVehicleNumberTableAdapter.Fill(aFindFleetIOVehicleByVehicleNumberDataSet.FindFleetIOVehicleByVehicleNumber, strFleetIOVehicleNumber);

            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Find Fleet IO Vehicle By Vehicle Number " + Ex.ToString());
            }

            return aFindFleetIOVehicleByVehicleNumberDataSet;
        }
        public FindFleetIOVehicleDataSet FindFleetIOVehicle(int intFleetIOVehicle)
        {
            try
            {
                aFindFleetIOVehicleDataSet = new FindFleetIOVehicleDataSet();
                aFindFleetIOVehicleTableAdapter = new FindFleetIOVehicleDataSetTableAdapters.FindFleetIOVehicleTableAdapter();
                aFindFleetIOVehicleTableAdapter.Fill(aFindFleetIOVehicleDataSet.FindFleetIOVehicle, intFleetIOVehicle);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Find Fleet IO Vehicle " + Ex.ToString());
            }

            return aFindFleetIOVehicleDataSet;
        }

        public bool InsertFleetIOVehicle(int intFleetIOVehicleID, int intFleetIOVehicleYear, string strFleetIOVehicleNumber, string strFleetIOVehicleMake, string strFleetIOVehicleModel, string strFleetIOVehicleVIN, string strFleetIOVehicleType, string strFleetIOVehicleGroup, string strFleetIOVehicleLicensePlate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertFleetIOVehicleEntryTableAdapter = new InsertFleetIOVehicleEntryTableAdapters.QueriesTableAdapter();
                aInsertFleetIOVehicleEntryTableAdapter.InsertFleetIOVehicle(intFleetIOVehicleID, intFleetIOVehicleYear, strFleetIOVehicleNumber, strFleetIOVehicleMake, strFleetIOVehicleModel, strFleetIOVehicleVIN, strFleetIOVehicleType, strFleetIOVehicleGroup, strFleetIOVehicleLicensePlate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Insert Fleet IO Vehicle " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FleetIOVehiclesDataSet GetFleetIOVehiclesDB()
        {
            try
            {
                aFleetIOVehiclesDataSet = new FleetIOVehiclesDataSet();
                aFleetIOVehiclesTableAdapter = new FleetIOVehiclesDataSetTableAdapters.fleetiovehiclesTableAdapter();
                aFleetIOVehiclesTableAdapter.Fill(aFleetIOVehiclesDataSet.fleetiovehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Get Fleet IO Vehicles DB " + Ex.ToString());
            }

            return aFleetIOVehiclesDataSet;
        }
        public void UpdateFleetIOVehiclesDB(FleetIOVehiclesDataSet aFleetIOVehiclesDataSet)
        {
            try
            {
                aFleetIOVehiclesTableAdapter = new FleetIOVehiclesDataSetTableAdapters.fleetiovehiclesTableAdapter();
                aFleetIOVehiclesTableAdapter.Update(aFleetIOVehiclesDataSet.fleetiovehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "//Fleet IO Vehicles Class // Get Fleet IO Vehicles DB " + Ex.ToString());
            }
        }
    }
}
