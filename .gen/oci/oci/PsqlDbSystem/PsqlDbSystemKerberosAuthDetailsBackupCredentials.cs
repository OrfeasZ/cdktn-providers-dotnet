using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials")]
    public class PsqlDbSystemKerberosAuthDetailsBackupCredentials : oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/psql_db_system#keytab_secret_id PsqlDbSystem#keytab_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keytabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeytabSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/psql_db_system#keytab_secret_version PsqlDbSystem#keytab_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keytabSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeytabSecretVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/psql_db_system#realm_name PsqlDbSystem#realm_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RealmName
        {
            get;
            set;
        }
    }
}
