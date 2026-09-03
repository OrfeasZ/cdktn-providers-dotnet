using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEbsAttachments), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsAttachments")]
    public interface ICloudBridgeAssetAwsEbsAttachments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#device CloudBridgeAsset#device}.</summary>
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Device
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#instance_key CloudBridgeAsset#instance_key}.</summary>
        [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#is_delete_on_termination CloudBridgeAsset#is_delete_on_termination}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDeleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDeleteOnTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#volume_key CloudBridgeAsset#volume_key}.</summary>
        [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEbsAttachments), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsAttachments")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsAttachments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#device CloudBridgeAsset#device}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Device
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#instance_key CloudBridgeAsset#instance_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#is_delete_on_termination CloudBridgeAsset#is_delete_on_termination}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDeleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDeleteOnTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_bridge_asset#volume_key CloudBridgeAsset#volume_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
