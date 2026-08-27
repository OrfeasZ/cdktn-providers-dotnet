using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustClaimValidations), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustClaimValidations")]
    public interface IIdentityDomainsIdentityPropagationTrustClaimValidations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_propagation_trust#name IdentityDomainsIdentityPropagationTrust#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_propagation_trust#value IdentityDomainsIdentityPropagationTrust#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustClaimValidations), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustClaimValidations")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustClaimValidations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_propagation_trust#name IdentityDomainsIdentityPropagationTrust#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_propagation_trust#value IdentityDomainsIdentityPropagationTrust#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
