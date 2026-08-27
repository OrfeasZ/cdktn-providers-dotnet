using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2State")]
    public class CloudBridgeAssetAwsEc2State : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#code CloudBridgeAsset#code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#name CloudBridgeAsset#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
