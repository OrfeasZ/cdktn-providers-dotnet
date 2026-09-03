using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpManagementAppliance
{
    [JsiiInterface(nativeType: typeof(IOcvpManagementApplianceConfiguration), fullyQualifiedName: "oci.ocvpManagementAppliance.OcvpManagementApplianceConfiguration")]
    public interface IOcvpManagementApplianceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#is_log_ingestion_enabled OcvpManagementAppliance#is_log_ingestion_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isLogIngestionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsLogIngestionEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#is_metrics_collection_enabled OcvpManagementAppliance#is_metrics_collection_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMetricsCollectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsMetricsCollectionEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#metrics OcvpManagementAppliance#metrics}.</summary>
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Metrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#support_bundle_bucket_id OcvpManagementAppliance#support_bundle_bucket_id}.</summary>
        [JsiiProperty(name: "supportBundleBucketId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SupportBundleBucketId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpManagementApplianceConfiguration), fullyQualifiedName: "oci.ocvpManagementAppliance.OcvpManagementApplianceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpManagementAppliance.IOcvpManagementApplianceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#is_log_ingestion_enabled OcvpManagementAppliance#is_log_ingestion_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isLogIngestionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsLogIngestionEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#is_metrics_collection_enabled OcvpManagementAppliance#is_metrics_collection_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isMetricsCollectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsMetricsCollectionEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#metrics OcvpManagementAppliance#metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Metrics
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ocvp_management_appliance#support_bundle_bucket_id OcvpManagementAppliance#support_bundle_bucket_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportBundleBucketId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportBundleBucketId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
