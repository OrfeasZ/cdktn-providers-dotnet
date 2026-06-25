using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetAwsEbs), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEbs")]
    public interface ICloudBridgeAssetAwsEbs
    {
        /// <summary>attachments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#attachments CloudBridgeAsset#attachments}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsAttachments" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "attachments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsAttachments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Attachments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#availability_zone CloudBridgeAsset#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#iops CloudBridgeAsset#iops}.</summary>
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Iops
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#is_encrypted CloudBridgeAsset#is_encrypted}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEncrypted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#is_multi_attach_enabled CloudBridgeAsset#is_multi_attach_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMultiAttachEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMultiAttachEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#size_in_gi_bs CloudBridgeAsset#size_in_gi_bs}.</summary>
        [JsiiProperty(name: "sizeInGiBs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeInGiBs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#tags CloudBridgeAsset#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#throughput CloudBridgeAsset#throughput}.</summary>
        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Throughput
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#volume_key CloudBridgeAsset#volume_key}.</summary>
        [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#volume_type CloudBridgeAsset#volume_type}.</summary>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetAwsEbs), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEbs")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attachments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#attachments CloudBridgeAsset#attachments}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsAttachments" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attachments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsAttachments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Attachments
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#availability_zone CloudBridgeAsset#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#iops CloudBridgeAsset#iops}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Iops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#is_encrypted CloudBridgeAsset#is_encrypted}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEncrypted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#is_multi_attach_enabled CloudBridgeAsset#is_multi_attach_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isMultiAttachEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMultiAttachEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#size_in_gi_bs CloudBridgeAsset#size_in_gi_bs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeInGiBs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeInGiBs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#status CloudBridgeAsset#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#tags CloudBridgeAsset#tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEbsTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEbsTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#throughput CloudBridgeAsset#throughput}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Throughput
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#volume_key CloudBridgeAsset#volume_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/cloud_bridge_asset#volume_type CloudBridgeAsset#volume_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
