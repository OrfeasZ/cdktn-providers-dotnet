using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProofingProviderTemplate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_proofing_provider_template oci_identity_domains_identity_proofing_provider_template}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplate), fullyQualifiedName: "oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfig\"}}]")]
    public class IdentityDomainsIdentityProofingProviderTemplate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_proofing_provider_template oci_identity_domains_identity_proofing_provider_template} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsIdentityProofingProviderTemplate(Constructs.Construct scope, string id, oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityProofingProviderTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityProofingProviderTemplate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsIdentityProofingProviderTemplate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsIdentityProofingProviderTemplate to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsIdentityProofingProviderTemplate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsIdentityProofingProviderTemplate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsIdentityProofingProviderTemplate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_identity_proofing_provider_template#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsIdentityProofingProviderTemplate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsIdentityProofingProviderTemplate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration" />)[]</param>
        [JsiiMethod(name: "putConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplate))!;

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfigurationList\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfigurationList Configuration
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfigurationList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLockedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLockedByList\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLockedByList IdcsLockedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateIdcsLockedByList>()!;
        }

        [JsiiProperty(name: "idcsLockedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLockedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLockedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsLockedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateMetaList\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateMetaList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProofingProviderTemplateProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityProofingProviderTemplateProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServiceTypeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IdentityDomainsIdentityProofingProviderTemplate.IIdentityDomainsIdentityProofingProviderTemplateTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsIdentityProofingProviderTemplate.IdentityDomainsIdentityProofingProviderTemplateTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerificationUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityProofingProviderTemplateProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProofingProviderTemplateProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceType
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verificationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
