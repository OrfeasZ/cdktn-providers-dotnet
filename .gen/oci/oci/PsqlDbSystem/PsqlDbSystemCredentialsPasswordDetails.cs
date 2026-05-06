using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails")]
    public class PsqlDbSystemCredentialsPasswordDetails : oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#password_type PsqlDbSystem#password_type}.</summary>
        [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#password PsqlDbSystem#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#secret_id PsqlDbSystem#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#secret_version PsqlDbSystem#secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretVersion
        {
            get;
            set;
        }
    }
}
