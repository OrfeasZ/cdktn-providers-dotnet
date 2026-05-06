using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyCustomerSecretKey
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMyCustomerSecretKeyUser), fullyQualifiedName: "oci.identityDomainsMyCustomerSecretKey.IdentityDomainsMyCustomerSecretKeyUser")]
    public interface IIdentityDomainsMyCustomerSecretKeyUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#ocid IdentityDomainsMyCustomerSecretKey#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#value IdentityDomainsMyCustomerSecretKey#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMyCustomerSecretKeyUser), fullyQualifiedName: "oci.identityDomainsMyCustomerSecretKey.IdentityDomainsMyCustomerSecretKeyUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMyCustomerSecretKey.IIdentityDomainsMyCustomerSecretKeyUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#ocid IdentityDomainsMyCustomerSecretKey#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#value IdentityDomainsMyCustomerSecretKey#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
