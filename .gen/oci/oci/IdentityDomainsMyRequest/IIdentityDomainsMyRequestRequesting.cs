using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyRequest
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyRequestRequesting), fullyQualifiedName: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestRequesting")]
    public interface IIdentityDomainsMyRequestRequesting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#type IdentityDomainsMyRequest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#value IdentityDomainsMyRequest#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyRequestRequesting), fullyQualifiedName: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestRequesting")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyRequest.IIdentityDomainsMyRequestRequesting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#type IdentityDomainsMyRequest#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
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
