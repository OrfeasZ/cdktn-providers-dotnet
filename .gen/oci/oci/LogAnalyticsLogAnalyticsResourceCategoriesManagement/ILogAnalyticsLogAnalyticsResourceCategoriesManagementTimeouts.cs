using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsResourceCategoriesManagement
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsResourceCategoriesManagement.LogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts")]
    public interface ILogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#create LogAnalyticsLogAnalyticsResourceCategoriesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#delete LogAnalyticsLogAnalyticsResourceCategoriesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#update LogAnalyticsLogAnalyticsResourceCategoriesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsResourceCategoriesManagement.LogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsResourceCategoriesManagement.ILogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#create LogAnalyticsLogAnalyticsResourceCategoriesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#delete LogAnalyticsLogAnalyticsResourceCategoriesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#update LogAnalyticsLogAnalyticsResourceCategoriesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
