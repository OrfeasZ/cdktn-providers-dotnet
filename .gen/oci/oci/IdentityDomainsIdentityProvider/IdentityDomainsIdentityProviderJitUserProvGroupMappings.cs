using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings")]
    public class IdentityDomainsIdentityProviderJitUserProvGroupMappings : oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvGroupMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idp_group IdentityDomainsIdentityProvider#idp_group}.</summary>
        [JsiiProperty(name: "idpGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string IdpGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#value IdentityDomainsIdentityProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
