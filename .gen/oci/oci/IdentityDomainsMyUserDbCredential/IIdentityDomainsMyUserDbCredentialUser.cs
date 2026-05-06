using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyUserDbCredential
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyUserDbCredentialUser), fullyQualifiedName: "oci.identityDomainsMyUserDbCredential.IdentityDomainsMyUserDbCredentialUser")]
    public interface IIdentityDomainsMyUserDbCredentialUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#value IdentityDomainsMyUserDbCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#ocid IdentityDomainsMyUserDbCredential#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyUserDbCredentialUser), fullyQualifiedName: "oci.identityDomainsMyUserDbCredential.IdentityDomainsMyUserDbCredentialUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyUserDbCredential.IIdentityDomainsMyUserDbCredentialUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#value IdentityDomainsMyUserDbCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_user_db_credential#ocid IdentityDomainsMyUserDbCredential#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
