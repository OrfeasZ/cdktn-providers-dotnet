using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPolicy
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsPolicyRules), fullyQualifiedName: "oci.identityDomainsPolicy.IdentityDomainsPolicyRules")]
    public interface IIdentityDomainsPolicyRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#sequence IdentityDomainsPolicy#sequence}.</summary>
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}")]
        double Sequence
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#value IdentityDomainsPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsPolicyRules), fullyQualifiedName: "oci.identityDomainsPolicy.IdentityDomainsPolicyRules")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsPolicy.IIdentityDomainsPolicyRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_policy#sequence IdentityDomainsPolicy#sequence}.</summary>
            [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}")]
            public double Sequence
            {
                get => GetInstanceProperty<double>()!;
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
