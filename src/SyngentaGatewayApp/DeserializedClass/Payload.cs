using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.DeserializedClass
{
    public class Data1
    {
        public int TotalRecord { get; set; }
        public List<ListDatum> ListData { get; set; }
    }

    public class ItemLine
    {
        public string Name { get; set; }
        public List<object> MachineIds { get; set; }
        public List<ListMachine> ListMachine { get; set; }
        public List<object> PlannedStopTimeIds { get; set; }
        public List<object> ListPlannedStopTime { get; set; }
        public List<object> ShiftIds { get; set; }
        public List<object> ListShift { get; set; }
        public int WorkshopId { get; set; }
        public List<object> ParameterIds { get; set; }
        public List<object> ListParameter { get; set; }
        public List<object> EmployeeIds { get; set; }
        public List<object> ListEmployee { get; set; }
        public List<object> ShiftCheckPointIds { get; set; }
        public List<object> ListShiftCheckPoint { get; set; }
        public List<object> LineTransIds { get; set; }
        public List<object> ListLineTrans { get; set; }
        public string SerialCode { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
    }

    public class ItemMachine
    {
        public string Name { get; set; }
        public int LineId { get; set; }
        public ItemLine ItemLine { get; set; }
        public List<object> MachineBlockDataIds { get; set; }
        public List<object> ParameterIds { get; set; }
        public List<ListParameter> ListParameter { get; set; }
        public List<object> ShiftIds { get; set; }
        public List<object> ListShift { get; set; }
        public List<object> EmployeeIds { get; set; }
        public List<ListEmployee> ListEmployee { get; set; }
        public List<object> ProductMachineIds { get; set; }
        public List<object> ListProductMachine { get; set; }
        public List<object> MachineTransIds { get; set; }
        public List<object> ListMachineTrans { get; set; }
        public string SerialCode { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
        public List<ListMachineBlockDatum> ListMachineBlockData { get; set; }
    }

    public class ListDatum
    {
        public string SerialCode { get; set; }
        public int LineId { get; set; }
        public ItemLine ItemLine { get; set; }
        public string Name { get; set; }
        public List<ListMachineBlockDatum> ListMachineBlockData { get; set; }
        public List<object> ListProductMachine { get; set; }
        public List<object> ListMachineTrans { get; set; }
        public List<ListParameter> ListParameter { get; set; }
        public List<object> ListShift { get; set; }
        public List<ListEmployee> ListEmployee { get; set; }
        public string LineName { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
    }

    public class ListEmployee
    {
        public string DisplayName { get; set; }
        public int EnableFlag { get; set; }
        public int UserId { get; set; }
        public List<object> FactoryIds { get; set; }
        public List<object> ListFactory { get; set; }
        public List<object> WorkshopIds { get; set; }
        public List<object> ListWorkshop { get; set; }
        public List<object> LineIds { get; set; }
        public List<object> ListLine { get; set; }
        public List<object> MachineIds { get; set; }
        public List<object> ListMachine { get; set; }
        public List<object> EmployeeTransIds { get; set; }
        public List<object> ListEmployeeTrans { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
    }

    public class ListMachine
    {
        public string Name { get; set; }
        public int LineId { get; set; }
        public List<object> MachineBlockDataIds { get; set; }
        public List<ListMachineBlockDatum> ListMachineBlockData { get; set; }
        public List<object> ParameterIds { get; set; }
        public List<ListParameter> ListParameter { get; set; }
        public List<object> ShiftIds { get; set; }
        public List<object> ListShift { get; set; }
        public List<object> EmployeeIds { get; set; }
        public List<ListEmployee> ListEmployee { get; set; }
        public List<object> ProductMachineIds { get; set; }
        public List<object> ListProductMachine { get; set; }
        public List<object> MachineTransIds { get; set; }
        public List<object> ListMachineTrans { get; set; }
        public string SerialCode { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
        public ItemLine ItemLine { get; set; }
    }

    public class ListMachineBlockDatum
    {
        public int MachineStatus { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int DurationInMiliSeconds { get; set; }
        public int MachineId { get; set; }
        public int LossReasonId { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
        public ItemMachine ItemMachine { get; set; }
    }

    public class ListParameter
    {
        public string Name { get; set; }
        public string CurrentValueTagId { get; set; }
        public string MinValueTagId { get; set; }
        public string MaxValueTagId { get; set; }
        public string StandardValueTagId { get; set; }
        public string UnitOfMeasuring { get; set; }
        public int EnabledReadPLCFlag { get; set; }
        public int MachineId { get; set; }
        public List<object> LimitationIds { get; set; }
        public List<object> ListLimitation { get; set; }
        public List<object> TagIds { get; set; }
        public List<ListTag> ListTag { get; set; }
        public List<object> ParameterTransIds { get; set; }
        public List<object> ListParameterTrans { get; set; }
        public string SerialCode { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
        public ItemMachine ItemMachine { get; set; }
    }

    public class ListTag
    {
        public string Name { get; set; }
        public List<object> ParameterIds { get; set; }
        public List<object> ListParameter { get; set; }
        public List<object> TagTransIds { get; set; }
        public List<object> ListTagTrans { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DeletedFlag { get; set; }
    }

    public class Root
    {
        public string Status { get; set; }
        public Data1 Data { get; set; }
    }
}
