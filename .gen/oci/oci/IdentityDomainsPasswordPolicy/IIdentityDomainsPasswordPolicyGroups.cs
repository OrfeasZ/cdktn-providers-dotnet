using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsPasswordPolicy
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsPasswordPolicyGroups), fullyQualifiedName: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups")]
    public interface IIdentityDomainsPasswordPolicyGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#value IdentityDomainsPasswordPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsPasswordPolicyGroups), fullyQualifiedName: "oci.identityDomainsPasswordPolicy.IdentityDomainsPasswordPolicyGroups")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsPasswordPolicy.IIdentityDomainsPasswordPolicyGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_password_policy#value IdentityDomainsPasswordPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
