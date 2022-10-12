using System.Xml.Serialization;

namespace Data
{
    public abstract class DataResponse<TQueryResult> : IDataResponse
    {
        protected DataResponse()
        {
        }

        protected DataResponse(TQueryResult response)
        {
            Data = response;
        }

        [XmlElement("data")] public TQueryResult Data { get; set; }
    }
}