using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSetting.IdentityDomainsSettingPurgeConfigs")]
    public class IdentityDomainsSettingPurgeConfigs : oci.IdentityDomainsSetting.IIdentityDomainsSettingPurgeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#resource_name IdentityDomainsSetting#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#retention_period IdentityDomainsSetting#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionPeriod
        {
            get;
            set;
        }
    }
}
