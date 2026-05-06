using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSmtpCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSmtpCredentialTags), fullyQualifiedName: "oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTags")]
    public interface IIdentityDomainsSmtpCredentialTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#key IdentityDomainsSmtpCredential#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#value IdentityDomainsSmtpCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSmtpCredentialTags), fullyQualifiedName: "oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#key IdentityDomainsSmtpCredential#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#value IdentityDomainsSmtpCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
