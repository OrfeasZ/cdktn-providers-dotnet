using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#gecos IdentityDomainsUser#gecos}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gecos", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gecos
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#gid_number IdentityDomainsUser#gid_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gidNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GidNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#home_directory IdentityDomainsUser#home_directory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomeDirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#login_shell IdentityDomainsUser#login_shell}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginShell", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoginShell
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#uid_number IdentityDomainsUser#uid_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uidNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UidNumber
        {
            get;
            set;
        }
    }
}
