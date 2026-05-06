using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline oci_datascience_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatasciencePipeline.DatasciencePipeline), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineConfig\"}}]")]
    public class DatasciencePipeline : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline oci_datascience_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasciencePipeline(Constructs.Construct scope, string id, oci.DatasciencePipeline.IDatasciencePipelineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatasciencePipeline.IDatasciencePipelineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatasciencePipeline resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatasciencePipeline to import.</param>
        /// <param name="importFromId">The id of the existing DatasciencePipeline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatasciencePipeline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatasciencePipeline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatasciencePipeline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatasciencePipeline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatasciencePipeline.DatasciencePipeline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineConfigurationDetails\"}}]")]
        public virtual void PutConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInfrastructureConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineInfrastructureConfigurationDetails\"}}]")]
        public virtual void PutInfrastructureConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineInfrastructureConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineInfrastructureConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineLogConfigurationDetails\"}}]")]
        public virtual void PutLogConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineLogConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineLogConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepArtifact", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepArtifact\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepArtifact(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipeline.IDatasciencePipelineStepArtifact[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepArtifact).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepArtifact).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipeline.IDatasciencePipelineStepDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageMountConfigurationDetailsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageMountConfigurationDetailsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipeline.IDatasciencePipelineStorageMountConfigurationDetailsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStorageMountConfigurationDetailsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStorageMountConfigurationDetailsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatasciencePipeline.IDatasciencePipelineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigurationDetails")]
        public virtual void ResetConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteRelatedPipelineRuns")]
        public virtual void ResetDeleteRelatedPipelineRuns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInfrastructureConfigurationDetails")]
        public virtual void ResetInfrastructureConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfigurationDetails")]
        public virtual void ResetLogConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepArtifact")]
        public virtual void ResetStepArtifact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageMountConfigurationDetailsList")]
        public virtual void ResetStorageMountConfigurationDetailsList()
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
        = GetStaticProperty<string>(typeof(oci.DatasciencePipeline.DatasciencePipeline))!;

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineConfigurationDetailsOutputReference ConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineInfrastructureConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineInfrastructureConfigurationDetailsOutputReference InfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineInfrastructureConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineLogConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineLogConfigurationDetailsOutputReference LogConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineLogConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepArtifact", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepArtifactList\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepArtifactList StepArtifact
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepArtifactList>()!;
        }

        [JsiiProperty(name: "stepDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsList\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsList StepDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsList>()!;
        }

        [JsiiProperty(name: "storageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStorageMountConfigurationDetailsListStructList StorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineTimeoutsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineConfigurationDetails? ConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteRelatedPipelineRunsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteRelatedPipelineRunsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineInfrastructureConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineInfrastructureConfigurationDetails? InfrastructureConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineInfrastructureConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineLogConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineLogConfigurationDetails? LogConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineLogConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepArtifactInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepArtifact\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepArtifactInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageMountConfigurationDetailsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageMountConfigurationDetailsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteRelatedPipelineRuns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteRelatedPipelineRuns
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
