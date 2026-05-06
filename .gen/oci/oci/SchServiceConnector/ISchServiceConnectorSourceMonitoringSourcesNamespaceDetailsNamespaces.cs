using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces")]
    public interface ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces
    {
        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metrics SchServiceConnector#metrics}
        /// </remarks>
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesMetrics\"}")]
        oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesMetrics Metrics
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace SchServiceConnector#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metrics SchServiceConnector#metrics}
            /// </remarks>
            [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesMetrics\"}")]
            public oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesMetrics Metrics
            {
                get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesMetrics>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace SchServiceConnector#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
