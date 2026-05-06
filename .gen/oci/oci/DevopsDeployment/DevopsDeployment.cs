using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment oci_devops_deployment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DevopsDeployment.DevopsDeployment), fullyQualifiedName: "oci.devopsDeployment.DevopsDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentConfig\"}}]")]
    public class DevopsDeployment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment oci_devops_deployment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsDeployment(Constructs.Construct scope, string id, oci.DevopsDeployment.IDevopsDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DevopsDeployment.IDevopsDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DevopsDeployment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsDeployment to import.</param>
        /// <param name="importFromId">The id of the existing DevopsDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DevopsDeployment.DevopsDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeployArtifactOverrideArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments\"}}]")]
        public virtual void PutDeployArtifactOverrideArguments(oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentArguments\"}}]")]
        public virtual void PutDeploymentArguments(oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeployStageOverrideArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArguments\"}}]")]
        public virtual void PutDeployStageOverrideArguments(oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DevopsDeployment.IDevopsDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployment.IDevopsDeploymentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployArtifactOverrideArguments")]
        public virtual void ResetDeployArtifactOverrideArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentArguments")]
        public virtual void ResetDeploymentArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployStageId")]
        public virtual void ResetDeployStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployStageOverrideArguments")]
        public virtual void ResetDeployStageOverrideArguments()
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

        [JsiiMethod(name: "resetPreviousDeploymentId")]
        public virtual void ResetPreviousDeploymentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerNewDevopsDeployment")]
        public virtual void ResetTriggerNewDevopsDeployment()
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
        = GetStaticProperty<string>(typeof(oci.DevopsDeployment.DevopsDeployment))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployArtifactOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsOutputReference\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsOutputReference DeployArtifactOverrideArguments
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "deploymentArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentArgumentsOutputReference\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeploymentArgumentsOutputReference DeploymentArguments
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeploymentArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "deploymentExecutionProgress", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentExecutionProgressList\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeploymentExecutionProgressList DeploymentExecutionProgress
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeploymentExecutionProgressList>()!;
        }

        [JsiiProperty(name: "deployPipelineArtifacts", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployPipelineArtifactsList\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeployPipelineArtifactsList DeployPipelineArtifacts
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeployPipelineArtifactsList>()!;
        }

        [JsiiProperty(name: "deployPipelineEnvironments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployPipelineEnvironmentsList\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeployPipelineEnvironmentsList DeployPipelineEnvironments
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeployPipelineEnvironmentsList>()!;
        }

        [JsiiProperty(name: "deployStageOverrideArguments", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArgumentsOutputReference\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentDeployStageOverrideArgumentsOutputReference DeployStageOverrideArguments
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentDeployStageOverrideArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentTimeoutsOutputReference\"}")]
        public virtual oci.DevopsDeployment.DevopsDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DevopsDeployment.DevopsDeploymentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactOverrideArgumentsInput", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArguments\"}", isOptional: true)]
        public virtual oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments? DeployArtifactOverrideArgumentsInput
        {
            get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentArgumentsInput", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeploymentArguments\"}", isOptional: true)]
        public virtual oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments? DeploymentArgumentsInput
        {
            get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeploymentArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployPipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployPipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployStageOverrideArgumentsInput", typeJson: "{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArguments\"}", isOptional: true)]
        public virtual oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments? DeployStageOverrideArgumentsInput
        {
            get => GetInstanceProperty<oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments?>();
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
        [JsiiProperty(name: "previousDeploymentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreviousDeploymentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerNewDevopsDeploymentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TriggerNewDevopsDeploymentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployStageId
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

        [JsiiProperty(name: "previousDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousDeploymentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggerNewDevopsDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object TriggerNewDevopsDeployment
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
    }
}
