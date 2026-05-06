using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyApiKey
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyApiKeyTags), fullyQualifiedName: "oci.identityDomainsMyApiKey.IdentityDomainsMyApiKeyTags")]
    public interface IIdentityDomainsMyApiKeyTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_api_key#key IdentityDomainsMyApiKey#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_api_key#value IdentityDomainsMyApiKey#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyApiKeyTags), fullyQualifiedName: "oci.identityDomainsMyApiKey.IdentityDomainsMyApiKeyTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyApiKey.IIdentityDomainsMyApiKeyTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_api_key#key IdentityDomainsMyApiKey#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_api_key#value IdentityDomainsMyApiKey#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
