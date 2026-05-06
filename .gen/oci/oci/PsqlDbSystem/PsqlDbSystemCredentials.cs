using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemCredentials")]
    public class PsqlDbSystemCredentials : oci.PsqlDbSystem.IPsqlDbSystemCredentials
    {
        /// <summary>password_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#password_details PsqlDbSystem#password_details}
        /// </remarks>
        [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails\"}")]
        public oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails PasswordDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#username PsqlDbSystem#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
