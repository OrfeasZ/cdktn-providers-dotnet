using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsRule
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsRulePolicyType), fullyQualifiedName: "oci.identityDomainsRule.IdentityDomainsRulePolicyType")]
    public interface IIdentityDomainsRulePolicyType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#value IdentityDomainsRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsRulePolicyType), fullyQualifiedName: "oci.identityDomainsRule.IdentityDomainsRulePolicyType")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsRule.IIdentityDomainsRulePolicyType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#value IdentityDomainsRule#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
