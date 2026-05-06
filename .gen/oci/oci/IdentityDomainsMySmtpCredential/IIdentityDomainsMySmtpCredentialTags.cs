using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMySmtpCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMySmtpCredentialTags), fullyQualifiedName: "oci.identityDomainsMySmtpCredential.IdentityDomainsMySmtpCredentialTags")]
    public interface IIdentityDomainsMySmtpCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#key IdentityDomainsMySmtpCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#value IdentityDomainsMySmtpCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMySmtpCredentialTags), fullyQualifiedName: "oci.identityDomainsMySmtpCredential.IdentityDomainsMySmtpCredentialTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMySmtpCredential.IIdentityDomainsMySmtpCredentialTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#key IdentityDomainsMySmtpCredential#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_smtp_credential#value IdentityDomainsMySmtpCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
