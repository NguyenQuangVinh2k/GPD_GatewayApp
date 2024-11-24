using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.DeserializedClass
{
    public class JsonGetBatch
    {
        public BusinessErrorGetBatch businessError { get; set; }
        public List<ReGetBatch> res { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BatchLevelCollectionGetBatch
    {
        public int id { get; set; }
        public int count { get; set; }
        public int level { get; set; }
        public int batchId { get; set; }
        public string gtin { get; set; }
        public int sscc { get; set; }
        public int createdBy { get; set; }
        public object updatedBy { get; set; }
        public object expiryDate { get; set; }
        public DateTime createdDate { get; set; }
        public object updatedDate { get; set; }
        public int barcodeType { get; set; }
        public string ip { get; set; }
        public int acceptedCount { get; set; }
        public object gtinType { get; set; }
        public object companyPrefixId { get; set; }
        public int inter_val { get; set; }
        public int rejectedCount { get; set; }
        public int discardedCount { get; set; }
        public int sacceptedCount { get; set; }
        public int srejectedCount { get; set; }
        public int isbulk2dLvl { get; set; }
        public int isPallet { get; set; }
        public int isTopup { get; set; }
        public string caption { get; set; }
        public int partialSscc { get; set; }
        public int withparentcount { get; set; }
        public int withoutparentcount { get; set; }
        public int packingcount { get; set; }
        public int percentincr { get; set; }
        public int specimenCount { get; set; }
        public int postedSNCount { get; set; }
        public int unpostedSNCount { get; set; }
        public int snLength { get; set; }
        public int minLevel { get; set; }
        public int minCount { get; set; }
        public int TPIntegration { get; set; }
    }

    public class BusinessErrorGetBatch
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class LineDetailsCollectionGetBatch
    {
        public int id { get; set; }
        public int level { get; set; }
        public string ipAdress { get; set; }
        public int isActive { get; set; }
        public int lineId { get; set; }
    }

    public class LineMasterGetBatch
    {
        public int id { get; set; }
        public string name { get; set; }
        public int manfId { get; set; }
        public int plantId { get; set; }
        public int createdBy { get; set; }
        public object updatedby { get; set; }
        public List<LineDetailsCollectionGetBatch> lineDetailsCollection { get; set; }
        public DateTime createdDate { get; set; }
        public object updatedDate { get; set; }
        public int isActive { get; set; }
        public string lineIdentifier { get; set; }
        public string plantName { get; set; }
        public object assignBatchName { get; set; }
        public object ipAddress { get; set; }
        public object level1 { get; set; }
        public object level2 { get; set; }
        public object level3 { get; set; }
        public object level4 { get; set; }
        public object level5 { get; set; }
        public object level6 { get; set; }
    }
    public class ReGetBatch
    {
        public int id { get; set; }
        public string batchName { get; set; }
        public string lotNumber { get; set; }
        public int createdBy { get; set; }
        public int isactive { get; set; }
        public int updatedBy { get; set; }
        public List<BatchLevelCollectionGetBatch> batchLevelCollection { get; set; }
        public int productId { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public LineMasterGetBatch lineMaster { get; set; }
        public int finalStatus { get; set; }
        public DateTime eventPostTime { get; set; }
        public object createdByName { get; set; }
        public int specimenStatus { get; set; }
        public object companyPrefixCmbName { get; set; }
        public int isLineUp { get; set; }
        public int isbulk2d { get; set; }
        public string mfgDate { get; set; }
        public object batchRemarksCollection { get; set; }
        public int isClosed { get; set; }
        public int standardType { get; set; }
        public string erpBatchId { get; set; }
        public DateTime transferDate { get; set; }
        public object productName { get; set; }
        public object level { get; set; }
        public int mode { get; set; }
        public string expDate { get; set; }
        public string productCode { get; set; }
        public object lineName { get; set; }
        public int shipment { get; set; }
        public int isposted { get; set; }
        public int packagingType { get; set; }
        public string archived { get; set; }
        public int archiveStatus { get; set; }
        public int assignTo { get; set; }
        public object assignToName { get; set; }
        public object product { get; set; }
        public object productionid { get; set; }
        public int post_seq { get; set; }
        public object requestType { get; set; }
        public int prePrintedSerialCodeLength { get; set; }
        public object erpBatchDetails { get; set; }
        public int isEligibleForMDLP415 { get; set; }
        public object lineId { get; set; }
        public object batchActivityStatus { get; set; }
        public object nonVendorDetils { get; set; }
        public string productNameAndCode { get; set; }
        public int sampleMode { get; set; }
        public int totalSampleCount { get; set; }
        public object commSampleInterval { get; set; }
        public double tareWeight { get; set; }
        public int tabletCount { get; set; }
        public int istareWeightConfig { get; set; }
        public object salableQty { get; set; }
        public object batchExtQtyList { get; set; }
        public object pid { get; set; }
        public object pcode { get; set; }
        public object pisdava { get; set; }
        public int srCodeType { get; set; }
    }

}
