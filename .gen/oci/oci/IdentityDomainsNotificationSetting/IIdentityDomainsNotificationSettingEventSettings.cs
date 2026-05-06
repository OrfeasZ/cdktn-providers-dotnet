using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNotificationSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsNotificationSettingEventSettings), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingEventSettings")]
    public interface IIdentityDomainsNotificationSettingEventSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#event_id IdentityDomainsNotificationSetting#event_id}.</summary>
        [JsiiProperty(name: "eventId", typeJson: "{\"primitive\":\"string\"}")]
        string EventId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#enabled IdentityDomainsNotificationSetting#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsNotificationSettingEventSettings), fullyQualifiedName: "oci.identityDomainsNotificationSetting.IdentityDomainsNotificationSettingEventSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsNotificationSetting.IIdentityDomainsNotificationSettingEventSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#event_id IdentityDomainsNotificationSetting#event_id}.</summary>
            [JsiiProperty(name: "eventId", typeJson: "{\"primitive\":\"string\"}")]
            public string EventId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_notification_setting#enabled IdentityDomainsNotificationSetting#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
