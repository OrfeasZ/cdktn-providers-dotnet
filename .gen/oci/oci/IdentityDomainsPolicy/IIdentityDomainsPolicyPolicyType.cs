using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPolicy
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsPolicyPolicyType), fullyQualifiedName: "oci.identityDomainsPolicy.IdentityDomainsPolicyPolicyType")]
    public interface IIdentityDomainsPolicyPolicyType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#value IdentityDomainsPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsPolicyPolicyType), fullyQualifiedName: "oci.identityDomainsPolicy.IdentityDomainsPolicyPolicyType")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsPolicy.IIdentityDomainsPolicyPolicyType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#value IdentityDomainsPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
