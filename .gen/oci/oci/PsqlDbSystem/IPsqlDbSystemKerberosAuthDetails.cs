using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemKerberosAuthDetails), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails")]
    public interface IPsqlDbSystemKerberosAuthDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>backup_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#backup_credentials PsqlDbSystem#backup_credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backupCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackupCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#credentials PsqlDbSystem#credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Credentials
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemKerberosAuthDetails), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>backup_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#backup_credentials PsqlDbSystem#backup_credentials}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackupCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#credentials PsqlDbSystem#credentials}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Credentials
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
