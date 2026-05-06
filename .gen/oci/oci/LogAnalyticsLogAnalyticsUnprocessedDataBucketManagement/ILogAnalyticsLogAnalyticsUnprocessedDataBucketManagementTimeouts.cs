using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsUnprocessedDataBucketManagement.LogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts")]
    public interface ILogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#create LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#delete LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#update LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsUnprocessedDataBucketManagement.LogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement.ILogAnalyticsLogAnalyticsUnprocessedDataBucketManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#create LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#delete LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_unprocessed_data_bucket_management#update LogAnalyticsLogAnalyticsUnprocessedDataBucketManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
