using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookupsAppendDataManagement
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceLookupsAppendDataManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsAppendDataManagement.LogAnalyticsNamespaceLookupsAppendDataManagementTimeouts")]
    public interface ILogAnalyticsNamespaceLookupsAppendDataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_append_data_management#create LogAnalyticsNamespaceLookupsAppendDataManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceLookupsAppendDataManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsAppendDataManagement.LogAnalyticsNamespaceLookupsAppendDataManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceLookupsAppendDataManagement.ILogAnalyticsNamespaceLookupsAppendDataManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_append_data_management#create LogAnalyticsNamespaceLookupsAppendDataManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
