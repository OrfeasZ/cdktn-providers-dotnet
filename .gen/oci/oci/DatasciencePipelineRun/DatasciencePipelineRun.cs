using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run oci_datascience_pipeline_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatasciencePipelineRun.DatasciencePipelineRun), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunConfig\"}}]")]
    public class DatasciencePipelineRun : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run oci_datascience_pipeline_run} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasciencePipelineRun(Constructs.Construct scope, string id, oci.DatasciencePipelineRun.IDatasciencePipelineRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatasciencePipelineRun.IDatasciencePipelineRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatasciencePipelineRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatasciencePipelineRun to import.</param>
        /// <param name="importFromId">The id of the existing DatasciencePipelineRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatasciencePipelineRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatasciencePipelineRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatasciencePipelineRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatasciencePipelineRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatasciencePipelineRun.DatasciencePipelineRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetails\"}}]")]
        public virtual void PutConfigurationOverrideDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInfrastructureConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetails\"}}]")]
        public virtual void PutInfrastructureConfigurationOverrideDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunLogConfigurationOverrideDetails\"}}]")]
        public virtual void PutLogConfigurationOverrideDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunLogConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunLogConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepOverrideDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageMountConfigurationOverrideDetailsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageMountConfigurationOverrideDetailsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipelineRun.IDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatasciencePipelineRun.IDatasciencePipelineRunTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigurationOverrideDetails")]
        public virtual void ResetConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteRelatedJobRuns")]
        public virtual void ResetDeleteRelatedJobRuns()
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

        [JsiiMethod(name: "resetInfrastructureConfigurationOverrideDetails")]
        public virtual void ResetInfrastructureConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfigurationOverrideDetails")]
        public virtual void ResetLogConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpcParentRptUrl")]
        public virtual void ResetOpcParentRptUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParametersOverride")]
        public virtual void ResetParametersOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepOverrideDetails")]
        public virtual void ResetStepOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageMountConfigurationOverrideDetailsList")]
        public virtual void ResetStorageMountConfigurationOverrideDetailsList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemTags")]
        public virtual void ResetSystemTags()
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
        = GetStaticProperty<string>(typeof(oci.DatasciencePipelineRun.DatasciencePipelineRun))!;

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationDetailsList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunConfigurationDetailsList ConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "configurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetailsOutputReference ConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference InfrastructureConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunLogConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunLogConfigurationOverrideDetailsOutputReference LogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunLogConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "logDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunLogDetailsList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunLogDetailsList LogDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunLogDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepOverrideDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsList StepOverrideDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "stepRuns", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepRunsList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepRunsList StepRuns
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepRunsList>()!;
        }

        [JsiiProperty(name: "storageMountConfigurationOverrideDetailsList", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList StorageMountConfigurationOverrideDetailsList
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunTimeoutsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "configurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunConfigurationOverrideDetails? ConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteRelatedJobRunsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteRelatedJobRunsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "infrastructureConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails? InfrastructureConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunLogConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunLogConfigurationOverrideDetails? LogConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunLogConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opcParentRptUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpcParentRptUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersOverrideInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersOverrideInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepOverrideDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepOverrideDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageMountConfigurationOverrideDetailsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageMountConfigurationOverrideDetailsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SystemTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "deleteRelatedJobRuns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteRelatedJobRuns
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

        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcParentRptUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parametersOverride", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ParametersOverride
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
