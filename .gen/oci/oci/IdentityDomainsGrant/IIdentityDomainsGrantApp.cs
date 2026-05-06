using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGrantApp), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantApp")]
    public interface IIdentityDomainsGrantApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#value IdentityDomainsGrant#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGrantApp), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGrant.IIdentityDomainsGrantApp
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
