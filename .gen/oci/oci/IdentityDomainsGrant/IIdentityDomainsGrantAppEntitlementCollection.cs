using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGrantAppEntitlementCollection), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection")]
    public interface IIdentityDomainsGrantAppEntitlementCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#value IdentityDomainsGrant#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGrantAppEntitlementCollection), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#value IdentityDomainsGrant#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
