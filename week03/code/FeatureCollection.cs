public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
//     {
     public string type {get;set;}
//   type: "FeatureCollection",
    public Dictionary<string, MetaData> metadata {get;set;}
//   metadata: {
//     ...
//   },
    public decimal[] bbox {get;set;}
//   bbox: [
//     minimum longitude,
//     minimum latitude,
//     minimum depth,
//     maximum longitude,
//     maximum latitude,
//     maximum depth
//   ],
    public Dictionary<string, Feat> features;
//   features: [
//     {
//       type: "Feature",
//       properties: {
//          ...
//       },
    public Dictionary<string, Geometry> geometry {get;set;}
//       geometry: {
//            ...
//       },
        public string id {get;set;}
//       id: String
//     },
//   ]
       public class Feat{
        public string type {get;set;}
        public Dictionary<string, FeatureProperties> properties {get;set;}
    }
    public class FeatureProperties{
//         mag: Decimal,
//         place: String,
//         time: Long Integer,
//         updated: Long Integer,
//         tz: Integer,
//         url: String,
//         detail: String,
//         felt:Integer,
//         cdi: Decimal,
//         mmi: Decimal,
//         alert: String,
//         status: String,
//         tsunami: Integer,
//         sig:Integer,
//         net: String,
//         code: String,
//         ids: String,
//         sources: String,
//         types: String,
//         nst: Integer,
//         dmin: Decimal,
//         rms: Decimal,
//         gap: Decimal,
//         magType: String,
//         type: String
        public decimal mag {get;set;}
        public string place {get;set;}
        public long time {get;set;}
        public long updated {get;set;}
        public int tz {get;set;}
        public string url {get;set;}
        public string detail {get;set;}
        public int Felt { get; set; }
        public decimal Cdi { get; set; }
        public decimal Mmi { get; set; }
        public string Alert { get; set; }
        public string Status { get; set; }
        public int Tsunami { get; set; }
        public int Sig { get; set; }
        public string Net { get; set; }
        public string Code { get; set; }
        public string Ids { get; set; }
        public string Sources { get; set; }
        public string Types { get; set; }
        public int Nst { get; set; }
        public decimal Dmin { get; set; }
        public decimal Rms { get; set; }
        public decimal Gap { get; set; }
        public string MagType { get; set; }
        public string Type { get; set; }
    }
    public class Geometry{
//         type: "Point",
//         coordinates: [
//           longitude,
//           latitude,
//           depth
//         ]
        public string type {get;set;}
        public decimal[] coordinates {get;set;}
    }
}
 public class MetaData{
//     generated: Long Integer,
//     url: String,
//     title: String,
//     api: String,
//     count: Integer,
//     status: Integer
        public long generated { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string api { get; set; }
        public int count { get; set; }
        public int status { get; set; }
    }
