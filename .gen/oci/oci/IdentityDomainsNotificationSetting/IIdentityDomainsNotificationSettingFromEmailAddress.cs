using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNotificationSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsNotificationSettingFromEmailAddress), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingFromEmailAddress")]
    public interface IIdentityDomainsNotificationSettingFromEmailAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#validate IdentityDomainsNotificationSetting#validate}.</summary>
        [JsiiProperty(name: "validate", typeJson: "{\"primitive\":\"string\"}")]
        string Validate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#value IdentityDomainsNotificationSetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#display_name IdentityDomainsNotificationSetting#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsNotificationSettingFromEmailAddress), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingFromEmailAddress")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsNotificationSetting.IIdentityDomainsNotificationSettingFromEmailAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#validate IdentityDomainsNotificationSetting#validate}.</summary>
            [JsiiProperty(name: "validate", typeJson: "{\"primitive\":\"string\"}")]
            public string Validate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#value IdentityDomainsNotificationSetting#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#display_name IdentityDomainsNotificationSetting#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
