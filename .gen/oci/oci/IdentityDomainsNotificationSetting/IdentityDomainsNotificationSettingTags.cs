using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNotificationSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingTags")]
    public class IdentityDomainsNotificationSettingTags : oci.IdentityDomainsNotificationSetting.IIdentityDomainsNotificationSettingTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#key IdentityDomainsNotificationSetting#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#value IdentityDomainsNotificationSetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
