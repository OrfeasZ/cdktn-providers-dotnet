using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails")]
    public interface ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>namespaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespaces SchServiceConnector#namespaces}
        /// </remarks>
        [JsiiProperty(name: "namespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces\"},\"kind\":\"array\"}}]}}")]
        object Namespaces
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>namespaces block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespaces SchServiceConnector#namespaces}
            /// </remarks>
            [JsiiProperty(name: "namespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces\"},\"kind\":\"array\"}}]}}")]
            public object Namespaces
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
