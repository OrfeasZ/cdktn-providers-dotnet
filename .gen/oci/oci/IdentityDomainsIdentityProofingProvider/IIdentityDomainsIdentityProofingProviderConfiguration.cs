using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderConfiguration), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfiguration")]
    public interface IIdentityDomainsIdentityProofingProviderConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/identity_domains_identity_proofing_provider#name IdentityDomainsIdentityProofingProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/identity_domains_identity_proofing_provider#value IdentityDomainsIdentityProofingProvider#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderConfiguration), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/identity_domains_identity_proofing_provider#name IdentityDomainsIdentityProofingProvider#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/identity_domains_identity_proofing_provider#value IdentityDomainsIdentityProofingProvider#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
