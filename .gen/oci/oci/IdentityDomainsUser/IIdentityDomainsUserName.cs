using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserName), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserName")]
    public interface IIdentityDomainsUserName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#family_name IdentityDomainsUser#family_name}.</summary>
        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FamilyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#formatted IdentityDomainsUser#formatted}.</summary>
        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Formatted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#given_name IdentityDomainsUser#given_name}.</summary>
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GivenName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_prefix IdentityDomainsUser#honorific_prefix}.</summary>
        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HonorificPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_suffix IdentityDomainsUser#honorific_suffix}.</summary>
        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HonorificSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#middle_name IdentityDomainsUser#middle_name}.</summary>
        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MiddleName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserName), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserName")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#family_name IdentityDomainsUser#family_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FamilyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#formatted IdentityDomainsUser#formatted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Formatted
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#given_name IdentityDomainsUser#given_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GivenName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_prefix IdentityDomainsUser#honorific_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HonorificPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#honorific_suffix IdentityDomainsUser#honorific_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HonorificSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#middle_name IdentityDomainsUser#middle_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MiddleName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
