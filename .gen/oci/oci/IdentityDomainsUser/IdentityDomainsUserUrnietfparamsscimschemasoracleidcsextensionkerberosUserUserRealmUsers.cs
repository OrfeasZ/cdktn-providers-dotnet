using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserRealmUsers")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserRealmUsers : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserRealmUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#principal_name IdentityDomainsUser#principal_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrincipalName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#realm_name IdentityDomainsUser#realm_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RealmName
        {
            get;
            set;
        }
    }
}
