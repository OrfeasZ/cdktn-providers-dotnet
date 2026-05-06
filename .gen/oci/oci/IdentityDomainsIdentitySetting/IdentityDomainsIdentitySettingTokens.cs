using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokens")]
    public class IdentityDomainsIdentitySettingTokens : oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTokens
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#type IdentityDomainsIdentitySetting#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#expires_after IdentityDomainsIdentitySetting#expires_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAfter
        {
            get;
            set;
        }
    }
}
