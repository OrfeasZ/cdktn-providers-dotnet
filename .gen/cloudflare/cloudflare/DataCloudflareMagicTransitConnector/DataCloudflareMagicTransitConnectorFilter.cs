using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitConnector
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareMagicTransitConnector.DataCloudflareMagicTransitConnectorFilter")]
    public class DataCloudflareMagicTransitConnectorFilter : cloudflare.DataCloudflareMagicTransitConnector.IDataCloudflareMagicTransitConnectorFilter
    {
        /// <summary>Filter connectors by device type. Available values: "MANAGED", "LICENSED".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/magic_transit_connector#device_type DataCloudflareMagicTransitConnector#device_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceType
        {
            get;
            set;
        }
    }
}
