using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustCaCertChain), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChain")]
    public interface IIdentityDomainsIdentityPropagationTrustCaCertChain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_propagation_trust#root_cas IdentityDomainsIdentityPropagationTrust#root_cas}.</summary>
        [JsiiProperty(name: "rootCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RootCas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_propagation_trust#intermediate_cas IdentityDomainsIdentityPropagationTrust#intermediate_cas}.</summary>
        [JsiiProperty(name: "intermediateCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IntermediateCas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustCaCertChain), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustCaCertChain")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustCaCertChain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_propagation_trust#root_cas IdentityDomainsIdentityPropagationTrust#root_cas}.</summary>
            [JsiiProperty(name: "rootCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RootCas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/identity_domains_identity_propagation_trust#intermediate_cas IdentityDomainsIdentityPropagationTrust#intermediate_cas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intermediateCas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IntermediateCas
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
