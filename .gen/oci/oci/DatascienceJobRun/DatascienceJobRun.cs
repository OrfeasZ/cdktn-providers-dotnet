using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run oci_datascience_job_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatascienceJobRun.DatascienceJobRun), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunConfig\"}}]")]
    public class DatascienceJobRun : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run oci_datascience_job_run} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatascienceJobRun(Constructs.Construct scope, string id, oci.DatascienceJobRun.IDatascienceJobRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatascienceJobRun.IDatascienceJobRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatascienceJobRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatascienceJobRun to import.</param>
        /// <param name="importFromId">The id of the existing DatascienceJobRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatascienceJobRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatascienceJobRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatascienceJobRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatascienceJobRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatascienceJobRun.DatascienceJobRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putJobConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetails\"}}]")]
        public virtual void PutJobConfigurationOverrideDetails(oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobEnvironmentConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetails\"}}]")]
        public virtual void PutJobEnvironmentConfigurationOverrideDetails(oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobInfrastructureConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetails\"}}]")]
        public virtual void PutJobInfrastructureConfigurationOverrideDetails(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobLogConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetails\"}}]")]
        public virtual void PutJobLogConfigurationOverrideDetails(oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobNodeConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetails\"}}]")]
        public virtual void PutJobNodeConfigurationOverrideDetails(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatascienceJobRun.IDatascienceJobRunTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAsynchronous")]
        public virtual void ResetAsynchronous()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
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

        [JsiiMethod(name: "resetJobConfigurationOverrideDetails")]
        public virtual void ResetJobConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobEnvironmentConfigurationOverrideDetails")]
        public virtual void ResetJobEnvironmentConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobInfrastructureConfigurationOverrideDetails")]
        public virtual void ResetJobInfrastructureConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobLogConfigurationOverrideDetails")]
        public virtual void ResetJobLogConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobNodeConfigurationOverrideDetails")]
        public virtual void ResetJobNodeConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpcParentRptUrl")]
        public virtual void ResetOpcParentRptUrl()
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
        = GetStaticProperty<string>(typeof(oci.DatascienceJobRun.DatascienceJobRun))!;

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetailsOutputReference JobConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetailsOutputReference JobEnvironmentConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationDetailsList JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference JobInfrastructureConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetailsOutputReference JobLogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobNodeConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsOutputReference JobNodeConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobStorageMountConfigurationDetailsListStructList JobStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunLogDetailsList\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunLogDetailsList LogDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunLogDetailsList>()!;
        }

        [JsiiProperty(name: "nodeGroupDetailsList", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunNodeGroupDetailsListStructList\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunNodeGroupDetailsListStructList NodeGroupDetailsList
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunNodeGroupDetailsListStructList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunTimeoutsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "asynchronousInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AsynchronousInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "jobConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails? JobConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails? JobInfrastructureConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobLogConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNodeConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails? JobNodeConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opcParentRptUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpcParentRptUrlInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "asynchronous", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Asynchronous
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

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
