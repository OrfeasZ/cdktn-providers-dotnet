using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEc2SecurityGroups), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups")]
    public interface ICloudBridgeAssetAwsEc2SecurityGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#group_key CloudBridgeAsset#group_key}.</summary>
        [JsiiProperty(name: "groupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEc2SecurityGroups), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#group_key CloudBridgeAsset#group_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_bridge_asset#group_name CloudBridgeAsset#group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
