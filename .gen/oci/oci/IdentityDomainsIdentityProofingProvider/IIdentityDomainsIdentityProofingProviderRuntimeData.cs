using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderRuntimeData), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderRuntimeData")]
    public interface IIdentityDomainsIdentityProofingProviderRuntimeData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#attr_name IdentityDomainsIdentityProofingProvider#attr_name}.</summary>
        [JsiiProperty(name: "attrName", typeJson: "{\"primitive\":\"string\"}")]
        string AttrName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#attr_value IdentityDomainsIdentityProofingProvider#attr_value}.</summary>
        [JsiiProperty(name: "attrValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttrValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderRuntimeData), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderRuntimeData")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderRuntimeData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#attr_name IdentityDomainsIdentityProofingProvider#attr_name}.</summary>
            [JsiiProperty(name: "attrName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttrName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_identity_proofing_provider#attr_value IdentityDomainsIdentityProofingProvider#attr_value}.</summary>
            [JsiiProperty(name: "attrValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttrValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
