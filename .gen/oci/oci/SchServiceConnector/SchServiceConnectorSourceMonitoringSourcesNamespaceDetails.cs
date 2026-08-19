using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails")]
    public class SchServiceConnectorSourceMonitoringSourcesNamespaceDetails : oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        private object _namespaces;

        /// <summary>namespaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/sch_service_connector#namespaces SchServiceConnector#namespaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "namespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces\"},\"kind\":\"array\"}}]}}")]
        public object Namespaces
        {
            get => _namespaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _namespaces = value;
            }
        }
    }
}
