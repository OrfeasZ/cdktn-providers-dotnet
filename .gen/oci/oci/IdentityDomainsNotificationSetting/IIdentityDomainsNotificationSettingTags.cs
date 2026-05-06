using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNotificationSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsNotificationSettingTags), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingTags")]
    public interface IIdentityDomainsNotificationSettingTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#key IdentityDomainsNotificationSetting#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#value IdentityDomainsNotificationSetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsNotificationSettingTags), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsNotificationSetting.IIdentityDomainsNotificationSettingTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#key IdentityDomainsNotificationSetting#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#value IdentityDomainsNotificationSetting#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
