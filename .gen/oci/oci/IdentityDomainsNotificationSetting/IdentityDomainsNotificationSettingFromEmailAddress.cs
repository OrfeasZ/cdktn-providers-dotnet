using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNotificationSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingFromEmailAddress")]
    public class IdentityDomainsNotificationSettingFromEmailAddress : oci.IdentityDomainsNotificationSetting.IIdentityDomainsNotificationSettingFromEmailAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#validate IdentityDomainsNotificationSetting#validate}.</summary>
        [JsiiProperty(name: "validate", typeJson: "{\"primitive\":\"string\"}")]
        public string Validate
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#display_name IdentityDomainsNotificationSetting#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
