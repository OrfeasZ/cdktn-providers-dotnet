using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSocialIdentityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsSocialIdentityProvider.IdentityDomainsSocialIdentityProviderRelayIdpParamMappings")]
    public class IdentityDomainsSocialIdentityProviderRelayIdpParamMappings : oci.IdentityDomainsSocialIdentityProvider.IIdentityDomainsSocialIdentityProviderRelayIdpParamMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_key IdentityDomainsSocialIdentityProvider#relay_param_key}.</summary>
        [JsiiProperty(name: "relayParamKey", typeJson: "{\"primitive\":\"string\"}")]
        public string RelayParamKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_social_identity_provider#relay_param_value IdentityDomainsSocialIdentityProvider#relay_param_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relayParamValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelayParamValue
        {
            get;
            set;
        }
    }
}
