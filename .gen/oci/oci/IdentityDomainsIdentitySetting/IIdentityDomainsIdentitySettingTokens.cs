using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentitySettingTokens), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokens")]
    public interface IIdentityDomainsIdentitySettingTokens
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#type IdentityDomainsIdentitySetting#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#expires_after IdentityDomainsIdentitySetting#expires_after}.</summary>
        [JsiiProperty(name: "expiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentitySettingTokens), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokens")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTokens
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#type IdentityDomainsIdentitySetting#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#expires_after IdentityDomainsIdentitySetting#expires_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
