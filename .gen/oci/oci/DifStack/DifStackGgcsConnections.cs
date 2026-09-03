using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackGgcsConnections")]
    public class DifStackGgcsConnections : oci.DifStack.IDifStackGgcsConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#connection_name DifStack#connection_name}.</summary>
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#connection_id DifStack#connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionId
        {
            get;
            set;
        }

        private object? _difDependencies;

        /// <summary>dif_dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnectionsDifDependencies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnectionsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DifStack.IDifStackGgcsConnectionsDifDependencies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGgcsConnectionsDifDependencies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _difDependencies = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#gg_admin_secret_id DifStack#gg_admin_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ggAdminSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GgAdminSecretId
        {
            get;
            set;
        }
    }
}
