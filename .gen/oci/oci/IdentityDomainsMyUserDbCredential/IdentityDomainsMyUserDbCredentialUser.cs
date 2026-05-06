using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyUserDbCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyUserDbCredential.IdentityDomainsMyUserDbCredentialUser")]
    public class IdentityDomainsMyUserDbCredentialUser : oci.IdentityDomainsMyUserDbCredential.IIdentityDomainsMyUserDbCredentialUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#value IdentityDomainsMyUserDbCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#ocid IdentityDomainsMyUserDbCredential#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }
    }
}
