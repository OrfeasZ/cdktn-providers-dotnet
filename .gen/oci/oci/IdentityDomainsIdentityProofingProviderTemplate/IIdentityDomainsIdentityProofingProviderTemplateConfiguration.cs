using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProviderTemplate
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderTemplateConfiguration), fullyQualifiedName: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration")]
    public interface IIdentityDomainsIdentityProofingProviderTemplateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#name IdentityDomainsIdentityProofingProviderTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#sensitivity IdentityDomainsIdentityProofingProviderTemplate#sensitivity}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sensitivity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Sensitivity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#type IdentityDomainsIdentityProofingProviderTemplate#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderTemplateConfiguration), fullyQualifiedName: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#name IdentityDomainsIdentityProofingProviderTemplate#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#sensitivity IdentityDomainsIdentityProofingProviderTemplate#sensitivity}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "sensitivity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Sensitivity
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_identity_proofing_provider_template#type IdentityDomainsIdentityProofingProviderTemplate#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
