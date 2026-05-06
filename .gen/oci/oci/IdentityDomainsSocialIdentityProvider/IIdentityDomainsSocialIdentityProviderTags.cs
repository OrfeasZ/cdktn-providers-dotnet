using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSocialIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSocialIdentityProviderTags), fullyQualifiedName: "oci.identityDomainsSocialIdentityProvider.IdentityDomainsSocialIdentityProviderTags")]
    public interface IIdentityDomainsSocialIdentityProviderTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#key IdentityDomainsSocialIdentityProvider#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#value IdentityDomainsSocialIdentityProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSocialIdentityProviderTags), fullyQualifiedName: "oci.identityDomainsSocialIdentityProvider.IdentityDomainsSocialIdentityProviderTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSocialIdentityProvider.IIdentityDomainsSocialIdentityProviderTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#key IdentityDomainsSocialIdentityProvider#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#value IdentityDomainsSocialIdentityProvider#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
