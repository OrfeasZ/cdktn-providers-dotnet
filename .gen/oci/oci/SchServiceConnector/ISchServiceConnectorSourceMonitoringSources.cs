using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorSourceMonitoringSources), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources")]
    public interface ISchServiceConnectorSourceMonitoringSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>namespace_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace_details SchServiceConnector#namespace_details}
        /// </remarks>
        [JsiiProperty(name: "namespaceDetails", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails? NamespaceDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorSourceMonitoringSources), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>namespace_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace_details SchServiceConnector#namespace_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceDetails", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}", isOptional: true)]
            public oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails? NamespaceDetails
            {
                get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails?>();
            }
        }
    }
}
