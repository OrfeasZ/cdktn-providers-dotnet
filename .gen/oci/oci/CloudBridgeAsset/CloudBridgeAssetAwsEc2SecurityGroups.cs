using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups")]
    public class CloudBridgeAssetAwsEc2SecurityGroups : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#group_key CloudBridgeAsset#group_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupName
        {
            get;
            set;
        }
    }
}
