using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGrantEntitlement), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantEntitlement")]
    public interface IIdentityDomainsGrantEntitlement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_name IdentityDomainsGrant#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_value IdentityDomainsGrant#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGrantEntitlement), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrantEntitlement")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_name IdentityDomainsGrant#attribute_name}.</summary>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_value IdentityDomainsGrant#attribute_value}.</summary>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
