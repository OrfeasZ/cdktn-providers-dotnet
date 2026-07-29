using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackDataflowConnectionsConnectionDetails), fullyQualifiedName: "oci.difStack.DifStackDataflowConnectionsConnectionDetails")]
    public interface IDifStackDataflowConnectionsConnectionDetails
    {
        /// <summary>dif_dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DifDependencies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#domain_names DifStack#domain_names}.</summary>
        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DomainNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackDataflowConnectionsConnectionDetails), fullyQualifiedName: "oci.difStack.DifStackDataflowConnectionsConnectionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackDataflowConnectionsConnectionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dif_dependencies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DifDependencies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#domain_names DifStack#domain_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DomainNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
