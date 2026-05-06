using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSocialIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSocialIdentityProviderRelayIdpParamMappings), fullyQualifiedName: "oci.identityDomainsSocialIdentityProvider.IdentityDomainsSocialIdentityProviderRelayIdpParamMappings")]
    public interface IIdentityDomainsSocialIdentityProviderRelayIdpParamMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_key IdentityDomainsSocialIdentityProvider#relay_param_key}.</summary>
        [JsiiProperty(name: "relayParamKey", typeJson: "{\"primitive\":\"string\"}")]
        string RelayParamKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_value IdentityDomainsSocialIdentityProvider#relay_param_value}.</summary>
        [JsiiProperty(name: "relayParamValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelayParamValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSocialIdentityProviderRelayIdpParamMappings), fullyQualifiedName: "oci.identityDomainsSocialIdentityProvider.IdentityDomainsSocialIdentityProviderRelayIdpParamMappings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSocialIdentityProvider.IIdentityDomainsSocialIdentityProviderRelayIdpParamMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_key IdentityDomainsSocialIdentityProvider#relay_param_key}.</summary>
            [JsiiProperty(name: "relayParamKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RelayParamKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_value IdentityDomainsSocialIdentityProvider#relay_param_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relayParamValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelayParamValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
