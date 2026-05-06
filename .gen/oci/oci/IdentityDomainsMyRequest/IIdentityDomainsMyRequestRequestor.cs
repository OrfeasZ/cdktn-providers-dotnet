using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyRequest
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyRequestRequestor), fullyQualifiedName: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestRequestor")]
    public interface IIdentityDomainsMyRequestRequestor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#value IdentityDomainsMyRequest#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyRequestRequestor), fullyQualifiedName: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestRequestor")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyRequest.IIdentityDomainsMyRequestRequestor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#value IdentityDomainsMyRequest#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
