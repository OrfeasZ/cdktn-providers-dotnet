using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProviderJitUserProvGroupMappings), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings")]
    public interface IIdentityDomainsIdentityProviderJitUserProvGroupMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idp_group IdentityDomainsIdentityProvider#idp_group}.</summary>
        [JsiiProperty(name: "idpGroup", typeJson: "{\"primitive\":\"string\"}")]
        string IdpGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#value IdentityDomainsIdentityProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProviderJitUserProvGroupMappings), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvGroupMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#idp_group IdentityDomainsIdentityProvider#idp_group}.</summary>
            [JsiiProperty(name: "idpGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string IdpGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#value IdentityDomainsIdentityProvider#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
