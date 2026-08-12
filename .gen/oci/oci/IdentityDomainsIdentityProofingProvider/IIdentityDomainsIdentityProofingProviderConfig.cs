using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProofingProviderConfig), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfig")]
    public interface IIdentityDomainsIdentityProofingProviderConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>claim_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#claim_mapping IdentityDomainsIdentityProofingProvider#claim_mapping}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderClaimMapping" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "claimMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderClaimMapping\"},\"kind\":\"array\"}}]}}")]
        object ClaimMapping
        {
            get;
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#configuration IdentityDomainsIdentityProofingProvider#configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfiguration\"},\"kind\":\"array\"}}]}}")]
        object Configuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#idcs_endpoint IdentityDomainsIdentityProofingProvider#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#identity_proofing_provider_provider IdentityDomainsIdentityProofingProvider#identity_proofing_provider_provider}.</summary>
        [JsiiProperty(name: "identityProofingProviderProvider", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProofingProviderProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#name IdentityDomainsIdentityProofingProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#schemas IdentityDomainsIdentityProofingProvider#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#attributes IdentityDomainsIdentityProofingProvider#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#attribute_sets IdentityDomainsIdentityProofingProvider#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#authorization IdentityDomainsIdentityProofingProvider#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#description IdentityDomainsIdentityProofingProvider#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#ocid IdentityDomainsIdentityProofingProvider#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#resource_type_schema_version IdentityDomainsIdentityProofingProvider#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#runtime_data IdentityDomainsIdentityProofingProvider#runtime_data}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderRuntimeData" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "runtimeData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderRuntimeData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuntimeData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#status IdentityDomainsIdentityProofingProvider#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#timeouts IdentityDomainsIdentityProofingProvider#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProofingProviderConfig), fullyQualifiedName: "oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>claim_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#claim_mapping IdentityDomainsIdentityProofingProvider#claim_mapping}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderClaimMapping" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "claimMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderClaimMapping\"},\"kind\":\"array\"}}]}}")]
            public object ClaimMapping
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#configuration IdentityDomainsIdentityProofingProvider#configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderConfiguration" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderConfiguration\"},\"kind\":\"array\"}}]}}")]
            public object Configuration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#idcs_endpoint IdentityDomainsIdentityProofingProvider#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#identity_proofing_provider_provider IdentityDomainsIdentityProofingProvider#identity_proofing_provider_provider}.</summary>
            [JsiiProperty(name: "identityProofingProviderProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProofingProviderProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#name IdentityDomainsIdentityProofingProvider#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#schemas IdentityDomainsIdentityProofingProvider#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#attributes IdentityDomainsIdentityProofingProvider#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#attribute_sets IdentityDomainsIdentityProofingProvider#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#authorization IdentityDomainsIdentityProofingProvider#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#description IdentityDomainsIdentityProofingProvider#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#ocid IdentityDomainsIdentityProofingProvider#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#resource_type_schema_version IdentityDomainsIdentityProofingProvider#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>runtime_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#runtime_data IdentityDomainsIdentityProofingProvider#runtime_data}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderRuntimeData" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderRuntimeData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuntimeData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#status IdentityDomainsIdentityProofingProvider#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_identity_proofing_provider#timeouts IdentityDomainsIdentityProofingProvider#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProvider.IdentityDomainsIdentityProofingProviderTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProvider.IIdentityDomainsIdentityProofingProviderTimeouts?>();
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
