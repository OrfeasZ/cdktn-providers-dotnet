using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProviderTemplate
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderTemplateConfig), fullyQualifiedName: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfig")]
    public interface IIdentityDomainsIdentityProofingProviderTemplateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#idcs_endpoint IdentityDomainsIdentityProofingProviderTemplate#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#identity_proofing_provider_template_provider IdentityDomainsIdentityProofingProviderTemplate#identity_proofing_provider_template_provider}.</summary>
        [JsiiProperty(name: "identityProofingProviderTemplateProvider", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProofingProviderTemplateProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#schemas IdentityDomainsIdentityProofingProviderTemplate#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#service_type IdentityDomainsIdentityProofingProviderTemplate#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#verification_url IdentityDomainsIdentityProofingProviderTemplate#verification_url}.</summary>
        [JsiiProperty(name: "verificationUrl", typeJson: "{\"primitive\":\"string\"}")]
        string VerificationUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#attributes IdentityDomainsIdentityProofingProviderTemplate#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#attribute_sets IdentityDomainsIdentityProofingProviderTemplate#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#authorization IdentityDomainsIdentityProofingProviderTemplate#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#configuration IdentityDomainsIdentityProofingProviderTemplate#configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#ocid IdentityDomainsIdentityProofingProviderTemplate#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#resource_type_schema_version IdentityDomainsIdentityProofingProviderTemplate#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#timeouts IdentityDomainsIdentityProofingProviderTemplate#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderTemplateConfig), fullyQualifiedName: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#idcs_endpoint IdentityDomainsIdentityProofingProviderTemplate#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#identity_proofing_provider_template_provider IdentityDomainsIdentityProofingProviderTemplate#identity_proofing_provider_template_provider}.</summary>
            [JsiiProperty(name: "identityProofingProviderTemplateProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProofingProviderTemplateProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#schemas IdentityDomainsIdentityProofingProviderTemplate#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#service_type IdentityDomainsIdentityProofingProviderTemplate#service_type}.</summary>
            [JsiiProperty(name: "serviceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ServiceType
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#verification_url IdentityDomainsIdentityProofingProviderTemplate#verification_url}.</summary>
            [JsiiProperty(name: "verificationUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string VerificationUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#attributes IdentityDomainsIdentityProofingProviderTemplate#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#attribute_sets IdentityDomainsIdentityProofingProviderTemplate#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#authorization IdentityDomainsIdentityProofingProviderTemplate#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#configuration IdentityDomainsIdentityProofingProviderTemplate#configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Configuration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#ocid IdentityDomainsIdentityProofingProviderTemplate#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#resource_type_schema_version IdentityDomainsIdentityProofingProviderTemplate#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider_template#timeouts IdentityDomainsIdentityProofingProviderTemplate#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
