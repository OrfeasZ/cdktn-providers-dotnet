using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
    {
        /// <summary>factor_identifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_identifier IdentityDomainsUser#factor_identifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "factorIdentifier", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserFactorIdentifier? FactorIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_method IdentityDomainsUser#factor_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "factorMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FactorMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_type IdentityDomainsUser#factor_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "factorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FactorType
        {
            get;
            set;
        }
    }
}
