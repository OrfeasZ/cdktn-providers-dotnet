using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUserDbCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserDbCredentialUser), fullyQualifiedName: "oci.identityDomainsUserDbCredential.IdentityDomainsUserDbCredentialUser")]
    public interface IIdentityDomainsUserDbCredentialUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#value IdentityDomainsUserDbCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#ocid IdentityDomainsUserDbCredential#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserDbCredentialUser), fullyQualifiedName: "oci.identityDomainsUserDbCredential.IdentityDomainsUserDbCredentialUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUserDbCredential.IIdentityDomainsUserDbCredentialUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#value IdentityDomainsUserDbCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user_db_credential#ocid IdentityDomainsUserDbCredential#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
