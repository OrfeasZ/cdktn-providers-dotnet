using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authentication_method IdentityDomainsUser#authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display IdentityDomainsUser#display}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Display
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_status IdentityDomainsUser#factor_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "factorStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FactorStatus
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#last_sync_time IdentityDomainsUser#last_sync_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastSyncTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastSyncTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#status IdentityDomainsUser#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#third_party_vendor_name IdentityDomainsUser#third_party_vendor_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thirdPartyVendorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThirdPartyVendorName
        {
            get;
            set;
        }
    }
}
