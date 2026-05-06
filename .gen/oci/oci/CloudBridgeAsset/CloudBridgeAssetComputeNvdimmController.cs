using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController")]
    public class CloudBridgeAssetComputeNvdimmController : oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#bus_number CloudBridgeAsset#bus_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "busNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BusNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#label CloudBridgeAsset#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }
    }
}
