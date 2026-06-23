using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitConnector
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareMagicTransitConnectorFilter), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitConnector.DataCloudflareMagicTransitConnectorFilter")]
    public interface IDataCloudflareMagicTransitConnectorFilter
    {
        /// <summary>Filter connectors by device type. Available values: "MANAGED", "LICENSED".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/magic_transit_connector#device_type DataCloudflareMagicTransitConnector#device_type}
        /// </remarks>
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareMagicTransitConnectorFilter), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitConnector.DataCloudflareMagicTransitConnectorFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareMagicTransitConnector.IDataCloudflareMagicTransitConnectorFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter connectors by device type. Available values: "MANAGED", "LICENSED".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/magic_transit_connector#device_type DataCloudflareMagicTransitConnector#device_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
