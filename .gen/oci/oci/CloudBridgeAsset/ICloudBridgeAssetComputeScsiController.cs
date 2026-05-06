using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetComputeScsiController), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController")]
    public interface ICloudBridgeAssetComputeScsiController
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#label CloudBridgeAsset#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#shared_bus CloudBridgeAsset#shared_bus}.</summary>
        [JsiiProperty(name: "sharedBus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedBus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#unit_number CloudBridgeAsset#unit_number}.</summary>
        [JsiiProperty(name: "unitNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnitNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetComputeScsiController), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#label CloudBridgeAsset#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#shared_bus CloudBridgeAsset#shared_bus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedBus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedBus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#unit_number CloudBridgeAsset#unit_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unitNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
