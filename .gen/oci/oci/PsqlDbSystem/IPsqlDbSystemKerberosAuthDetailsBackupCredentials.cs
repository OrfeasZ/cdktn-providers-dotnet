using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemKerberosAuthDetailsBackupCredentials), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials")]
    public interface IPsqlDbSystemKerberosAuthDetailsBackupCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#keytab_secret_id PsqlDbSystem#keytab_secret_id}.</summary>
        [JsiiProperty(name: "keytabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeytabSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#keytab_secret_version PsqlDbSystem#keytab_secret_version}.</summary>
        [JsiiProperty(name: "keytabSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeytabSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#realm_name PsqlDbSystem#realm_name}.</summary>
        [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RealmName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemKerberosAuthDetailsBackupCredentials), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#keytab_secret_id PsqlDbSystem#keytab_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keytabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeytabSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#keytab_secret_version PsqlDbSystem#keytab_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keytabSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeytabSecretVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/psql_db_system#realm_name PsqlDbSystem#realm_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RealmName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
