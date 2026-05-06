using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookupsUpdateDataManagement
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts")]
    public interface ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#create LogAnalyticsNamespaceLookupsUpdateDataManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#create LogAnalyticsNamespaceLookupsUpdateDataManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
