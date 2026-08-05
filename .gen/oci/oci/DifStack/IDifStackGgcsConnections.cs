using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGgcsConnections), fullyQualifiedName: "oci.difStack.DifStackGgcsConnections")]
    public interface IDifStackGgcsConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#connection_name DifStack#connection_name}.</summary>
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#connection_id DifStack#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>dif_dependencies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnectionsDifDependencies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnectionsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DifDependencies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#gg_admin_secret_id DifStack#gg_admin_secret_id}.</summary>
        [JsiiProperty(name: "ggAdminSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GgAdminSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGgcsConnections), fullyQualifiedName: "oci.difStack.DifStackGgcsConnections")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGgcsConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#connection_name DifStack#connection_name}.</summary>
            [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#connection_id DifStack#connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dif_dependencies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#dif_dependencies DifStack#dif_dependencies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnectionsDifDependencies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "difDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnectionsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DifDependencies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#gg_admin_secret_id DifStack#gg_admin_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ggAdminSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GgAdminSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
