using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSetting.IdentityDomainsSettingLoginTexts")]
    public class IdentityDomainsSettingLoginTexts : oci.IdentityDomainsSetting.IIdentityDomainsSettingLoginTexts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#locale IdentityDomainsSetting#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public string Locale
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#value IdentityDomainsSetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
