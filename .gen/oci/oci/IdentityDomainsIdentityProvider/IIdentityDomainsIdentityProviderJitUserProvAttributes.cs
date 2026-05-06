using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProviderJitUserProvAttributes), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes")]
    public interface IIdentityDomainsIdentityProviderJitUserProvAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#value IdentityDomainsIdentityProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProviderJitUserProvAttributes), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
