using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsDynamicResourceGroup
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags), fullyQualifiedName: "oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags")]
    public interface IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags
    {
        /// <summary>defined_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_dynamic_resource_group#defined_tags IdentityDomainsDynamicResourceGroup#defined_tags}
        /// </remarks>
        [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_dynamic_resource_group#freeform_tags IdentityDomainsDynamicResourceGroup#freeform_tags}
        /// </remarks>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FreeformTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags), fullyQualifiedName: "oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>defined_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_dynamic_resource_group#defined_tags IdentityDomainsDynamicResourceGroup#defined_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefinedTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>freeform_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_dynamic_resource_group#freeform_tags IdentityDomainsDynamicResourceGroup#freeform_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FreeformTags
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
