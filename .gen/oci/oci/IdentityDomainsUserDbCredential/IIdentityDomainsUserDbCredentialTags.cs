using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUserDbCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserDbCredentialTags), fullyQualifiedName: "oci.identityDomainsUserDbCredential.IdentityDomainsUserDbCredentialTags")]
    public interface IIdentityDomainsUserDbCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#key IdentityDomainsUserDbCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#value IdentityDomainsUserDbCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserDbCredentialTags), fullyQualifiedName: "oci.identityDomainsUserDbCredential.IdentityDomainsUserDbCredentialTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUserDbCredential.IIdentityDomainsUserDbCredentialTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#key IdentityDomainsUserDbCredential#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#value IdentityDomainsUserDbCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
