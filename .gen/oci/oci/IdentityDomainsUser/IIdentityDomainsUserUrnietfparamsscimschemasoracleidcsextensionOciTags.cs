using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags
    {
        /// <summary>defined_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#defined_tags IdentityDomainsUser#defined_tags}
        /// </remarks>
        [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>freeform_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#freeform_tags IdentityDomainsUser#freeform_tags}
        /// </remarks>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FreeformTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>defined_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#defined_tags IdentityDomainsUser#defined_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefinedTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>freeform_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#freeform_tags IdentityDomainsUser#freeform_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FreeformTags
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
