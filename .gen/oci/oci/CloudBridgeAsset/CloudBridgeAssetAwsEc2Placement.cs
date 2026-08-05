using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement")]
    public class CloudBridgeAssetAwsEc2Placement : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#affinity CloudBridgeAsset#affinity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Affinity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#availability_zone CloudBridgeAsset#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#host_key CloudBridgeAsset#host_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#host_resource_group_arn CloudBridgeAsset#host_resource_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostResourceGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#partition_number CloudBridgeAsset#partition_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PartitionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#spread_domain CloudBridgeAsset#spread_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpreadDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_bridge_asset#tenancy CloudBridgeAsset#tenancy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tenancy
        {
            get;
            set;
        }
    }
}
