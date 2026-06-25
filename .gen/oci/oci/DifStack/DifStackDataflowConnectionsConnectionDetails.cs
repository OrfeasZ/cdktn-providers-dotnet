using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiByValue(fqn: "oci.difStack.DifStackDataflowConnectionsConnectionDetails")]
    public class DifStackDataflowConnectionsConnectionDetails : oci.DifStack.IDifStackDataflowConnectionsConnectionDetails
    {
        private object? _difDependencies;

        /// <summary>dif_dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DifDependencies
        {
            get => _difDependencies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _difDependencies = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#domain_names DifStack#domain_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DomainNames
        {
            get;
            set;
        }
    }
}
