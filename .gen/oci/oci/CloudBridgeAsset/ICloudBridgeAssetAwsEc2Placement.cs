using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEc2Placement), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement")]
    public interface ICloudBridgeAssetAwsEc2Placement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#affinity CloudBridgeAsset#affinity}.</summary>
        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Affinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#availability_zone CloudBridgeAsset#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#host_key CloudBridgeAsset#host_key}.</summary>
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#host_resource_group_arn CloudBridgeAsset#host_resource_group_arn}.</summary>
        [JsiiProperty(name: "hostResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostResourceGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#partition_number CloudBridgeAsset#partition_number}.</summary>
        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartitionNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#spread_domain CloudBridgeAsset#spread_domain}.</summary>
        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpreadDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#tenancy CloudBridgeAsset#tenancy}.</summary>
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenancy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEc2Placement), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#affinity CloudBridgeAsset#affinity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Affinity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#availability_zone CloudBridgeAsset#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#host_key CloudBridgeAsset#host_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#host_resource_group_arn CloudBridgeAsset#host_resource_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostResourceGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#partition_number CloudBridgeAsset#partition_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartitionNumber
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#spread_domain CloudBridgeAsset#spread_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpreadDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/cloud_bridge_asset#tenancy CloudBridgeAsset#tenancy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenancy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
