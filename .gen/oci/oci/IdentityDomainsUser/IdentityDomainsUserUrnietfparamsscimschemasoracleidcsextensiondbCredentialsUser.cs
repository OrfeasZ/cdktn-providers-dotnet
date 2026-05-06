using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#db_user_name IdentityDomainsUser#db_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbUserName
        {
            get;
            set;
        }
    }
}
