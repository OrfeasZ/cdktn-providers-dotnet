using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMappedAttribute
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/identity_domains_mapped_attribute oci_identity_domains_mapped_attribute}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttribute), fullyQualifiedName: "oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttribute", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeConfig\"}}]")]
    public class IdentityDomainsMappedAttribute : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/identity_domains_mapped_attribute oci_identity_domains_mapped_attribute} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsMappedAttribute(Constructs.Construct scope, string id, oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsMappedAttribute(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsMappedAttribute(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsMappedAttribute resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsMappedAttribute to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsMappedAttribute that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsMappedAttribute to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsMappedAttribute to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/identity_domains_mapped_attribute#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsMappedAttribute that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsMappedAttribute to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttribute), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings" />)[]</param>
        [JsiiMethod(name: "putAttributeMappings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAttributeMappings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags" />)[]</param>
        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributeMappings")]
        public virtual void ResetAttributeMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttribute))!;

        [JsiiProperty(name: "attributeMappings", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappingsList\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappingsList AttributeMappings
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappingsList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeMetaList\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeMetaList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTagsList\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsMappedAttribute.IdentityDomainsMappedAttributeTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributeMappingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AttributeMappingsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "directionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mappedAttributeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MappedAttributeIdInput
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
        [JsiiProperty(name: "refResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefResourceTypeInput
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
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

        [JsiiProperty(name: "idcsResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mappedAttributeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MappedAttributeId
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

        [JsiiProperty(name: "refResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefResourceType
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
    }
}
