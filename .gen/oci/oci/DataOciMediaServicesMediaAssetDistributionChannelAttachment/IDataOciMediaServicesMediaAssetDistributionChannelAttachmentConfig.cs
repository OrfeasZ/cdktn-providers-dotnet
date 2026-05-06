using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesMediaAssetDistributionChannelAttachment
{
    [JsiiInterface(nativeType: typeof(IDataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig), fullyQualifiedName: "oci.dataOciMediaServicesMediaAssetDistributionChannelAttachment.DataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig")]
    public interface IDataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#distribution_channel_id DataOciMediaServicesMediaAssetDistributionChannelAttachment#distribution_channel_id}.</summary>
        [JsiiProperty(name: "distributionChannelId", typeJson: "{\"primitive\":\"string\"}")]
        string DistributionChannelId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#media_asset_id DataOciMediaServicesMediaAssetDistributionChannelAttachment#media_asset_id}.</summary>
        [JsiiProperty(name: "mediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        string MediaAssetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#id DataOciMediaServicesMediaAssetDistributionChannelAttachment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#is_lock_override DataOciMediaServicesMediaAssetDistributionChannelAttachment#is_lock_override}.</summary>
        [JsiiProperty(name: "isLockOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLockOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#locks DataOciMediaServicesMediaAssetDistributionChannelAttachment#locks}
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMediaServicesMediaAssetDistributionChannelAttachment.DataOciMediaServicesMediaAssetDistributionChannelAttachmentLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig), fullyQualifiedName: "oci.dataOciMediaServicesMediaAssetDistributionChannelAttachment.DataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciMediaServicesMediaAssetDistributionChannelAttachment.IDataOciMediaServicesMediaAssetDistributionChannelAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#distribution_channel_id DataOciMediaServicesMediaAssetDistributionChannelAttachment#distribution_channel_id}.</summary>
            [JsiiProperty(name: "distributionChannelId", typeJson: "{\"primitive\":\"string\"}")]
            public string DistributionChannelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#media_asset_id DataOciMediaServicesMediaAssetDistributionChannelAttachment#media_asset_id}.</summary>
            [JsiiProperty(name: "mediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
            public string MediaAssetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#id DataOciMediaServicesMediaAssetDistributionChannelAttachment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#is_lock_override DataOciMediaServicesMediaAssetDistributionChannelAttachment#is_lock_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLockOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLockOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>locks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#locks DataOciMediaServicesMediaAssetDistributionChannelAttachment#locks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMediaServicesMediaAssetDistributionChannelAttachment.DataOciMediaServicesMediaAssetDistributionChannelAttachmentLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Locks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
