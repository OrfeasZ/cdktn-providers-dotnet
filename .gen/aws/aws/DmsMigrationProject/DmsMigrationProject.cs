using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsMigrationProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/dms_migration_project aws_dms_migration_project}.</summary>
    [JsiiClass(nativeType: typeof(aws.DmsMigrationProject.DmsMigrationProject), fullyQualifiedName: "aws.dmsMigrationProject.DmsMigrationProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectConfig\"}}]")]
    public class DmsMigrationProject : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/dms_migration_project aws_dms_migration_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DmsMigrationProject(Constructs.Construct scope, string id, aws.DmsMigrationProject.IDmsMigrationProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DmsMigrationProject.IDmsMigrationProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsMigrationProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsMigrationProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DmsMigrationProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DmsMigrationProject to import.</param>
        /// <param name="importFromId">The id of the existing DmsMigrationProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DmsMigrationProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DmsMigrationProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/dms_migration_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DmsMigrationProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DmsMigrationProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DmsMigrationProject.DmsMigrationProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes" />)[]</param>
        [JsiiMethod(name: "putSchemaConversionApplicationAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchemaConversionApplicationAttributes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor" />)[]</param>
        [JsiiMethod(name: "putSourceDataProviderDescriptor", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptor\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceDataProviderDescriptor(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectTargetDataProviderDescriptor" />)[]</param>
        [JsiiMethod(name: "putTargetDataProviderDescriptor", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTargetDataProviderDescriptor\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTargetDataProviderDescriptor(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsMigrationProject.IDmsMigrationProjectTargetDataProviderDescriptor[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectTargetDataProviderDescriptor).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsMigrationProject.IDmsMigrationProjectTargetDataProviderDescriptor).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DmsMigrationProject.IDmsMigrationProjectTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsMigrationProject.IDmsMigrationProjectTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaConversionApplicationAttributes")]
        public virtual void ResetSchemaConversionApplicationAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDataProviderDescriptor")]
        public virtual void ResetSourceDataProviderDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetDataProviderDescriptor")]
        public virtual void ResetTargetDataProviderDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransformationRules")]
        public virtual void ResetTransformationRules()
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
        = GetStaticProperty<string>(typeof(aws.DmsMigrationProject.DmsMigrationProject))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaConversionApplicationAttributes", typeJson: "{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributesList\"}")]
        public virtual aws.DmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributesList SchemaConversionApplicationAttributes
        {
            get => GetInstanceProperty<aws.DmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributesList>()!;
        }

        [JsiiProperty(name: "sourceDataProviderDescriptor", typeJson: "{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptorList\"}")]
        public virtual aws.DmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptorList SourceDataProviderDescriptor
        {
            get => GetInstanceProperty<aws.DmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptorList>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDataProviderDescriptor", typeJson: "{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTargetDataProviderDescriptorList\"}")]
        public virtual aws.DmsMigrationProject.DmsMigrationProjectTargetDataProviderDescriptorList TargetDataProviderDescriptor
        {
            get => GetInstanceProperty<aws.DmsMigrationProject.DmsMigrationProjectTargetDataProviderDescriptorList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTimeoutsOutputReference\"}")]
        public virtual aws.DmsMigrationProject.DmsMigrationProjectTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DmsMigrationProject.DmsMigrationProjectTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceProfileArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceProfileArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaConversionApplicationAttributesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemaConversionApplicationAttributesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDataProviderDescriptorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceDataProviderDescriptorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsMigrationProject.IDmsMigrationProjectTargetDataProviderDescriptor" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetDataProviderDescriptorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTargetDataProviderDescriptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetDataProviderDescriptorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.DmsMigrationProject.IDmsMigrationProjectTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dmsMigrationProject.DmsMigrationProjectTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transformationRulesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransformationRulesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceProfileArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transformationRules", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransformationRules
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
