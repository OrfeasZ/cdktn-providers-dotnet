using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMySupportAccount
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMySupportAccountTags), fullyQualifiedName: "oci.identityDomainsMySupportAccount.IdentityDomainsMySupportAccountTags")]
    public interface IIdentityDomainsMySupportAccountTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_support_account#key IdentityDomainsMySupportAccount#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_support_account#value IdentityDomainsMySupportAccount#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMySupportAccountTags), fullyQualifiedName: "oci.identityDomainsMySupportAccount.IdentityDomainsMySupportAccountTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMySupportAccount.IIdentityDomainsMySupportAccountTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_support_account#key IdentityDomainsMySupportAccount#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_support_account#value IdentityDomainsMySupportAccount#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
