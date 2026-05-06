using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline oci_golden_gate_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(oci.GoldenGatePipeline.GoldenGatePipeline), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineConfig\"}}]")]
    public class GoldenGatePipeline : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline oci_golden_gate_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GoldenGatePipeline(Constructs.Construct scope, string id, oci.GoldenGatePipeline.IGoldenGatePipelineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.GoldenGatePipeline.IGoldenGatePipelineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGatePipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGatePipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a GoldenGatePipeline resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GoldenGatePipeline to import.</param>
        /// <param name="importFromId">The id of the existing GoldenGatePipeline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GoldenGatePipeline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GoldenGatePipeline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GoldenGatePipeline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GoldenGatePipeline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.GoldenGatePipeline.GoldenGatePipeline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLocks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineLocks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLocks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.GoldenGatePipeline.IGoldenGatePipelineLocks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GoldenGatePipeline.IGoldenGatePipelineLocks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GoldenGatePipeline.IGoldenGatePipelineLocks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptions\"}}]")]
        public virtual void PutProcessOptions(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineSourceConnectionDetails\"}}]")]
        public virtual void PutSourceConnectionDetails(oci.GoldenGatePipeline.IGoldenGatePipelineSourceConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineSourceConnectionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetails\"}}]")]
        public virtual void PutTargetConnectionDetails(oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.GoldenGatePipeline.IGoldenGatePipelineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetLocks")]
        public virtual void ResetLocks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessOptions")]
        public virtual void ResetProcessOptions()
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
        = GetStaticProperty<string>(typeof(oci.GoldenGatePipeline.GoldenGatePipeline))!;

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineLocksList\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineLocksList Locks
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineLocksList>()!;
        }

        [JsiiProperty(name: "mappingRules", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineMappingRulesList\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineMappingRulesList MappingRules
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineMappingRulesList>()!;
        }

        [JsiiProperty(name: "pipelineDiagnosticData", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelinePipelineDiagnosticDataList\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelinePipelineDiagnosticDataList PipelineDiagnosticData
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelinePipelineDiagnosticDataList>()!;
        }

        [JsiiProperty(name: "processOptions", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsOutputReference ProcessOptions
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sourceConnectionDetails", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineSourceConnectionDetailsOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineSourceConnectionDetailsOutputReference SourceConnectionDetails
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineSourceConnectionDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetConnectionDetails", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetailsOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineTargetConnectionDetailsOutputReference TargetConnectionDetails
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineTargetConnectionDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRecorded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRecorded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTimeoutsOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processOptionsInput", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptions\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions? ProcessOptionsInput
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecipeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceConnectionDetailsInput", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineSourceConnectionDetails\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineSourceConnectionDetails? SourceConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineSourceConnectionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetConnectionDetailsInput", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetails\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails? TargetConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recipeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecipeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
