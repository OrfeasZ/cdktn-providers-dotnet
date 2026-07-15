using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemReplicationConfig), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemReplicationConfig")]
    public interface IPsqlDbSystemReplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#is_rpo_enforced PsqlDbSystem#is_rpo_enforced}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRpoEnforced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRpoEnforced
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#rpo_in_seconds PsqlDbSystem#rpo_in_seconds}.</summary>
        [JsiiProperty(name: "rpoInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RpoInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemReplicationConfig), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemReplicationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#is_rpo_enforced PsqlDbSystem#is_rpo_enforced}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRpoEnforced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRpoEnforced
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#rpo_in_seconds PsqlDbSystem#rpo_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rpoInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RpoInSeconds
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
