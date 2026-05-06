using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMaintenanceRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_maintenance_run oci_database_maintenance_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseMaintenanceRun.DatabaseMaintenanceRun), fullyQualifiedName: "oci.databaseMaintenanceRun.DatabaseMaintenanceRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseMaintenanceRun.DatabaseMaintenanceRunConfig\"}}]")]
    public class DatabaseMaintenanceRun : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_maintenance_run oci_database_maintenance_run} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseMaintenanceRun(Constructs.Construct scope, string id, oci.DatabaseMaintenanceRun.IDatabaseMaintenanceRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseMaintenanceRun.IDatabaseMaintenanceRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMaintenanceRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMaintenanceRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseMaintenanceRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseMaintenanceRun to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseMaintenanceRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseMaintenanceRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseMaintenanceRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_maintenance_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseMaintenanceRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseMaintenanceRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseMaintenanceRun.DatabaseMaintenanceRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMaintenanceRun.DatabaseMaintenanceRunTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseMaintenanceRun.IDatabaseMaintenanceRunTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMaintenanceRun.IDatabaseMaintenanceRunTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseSoftwareImageId")]
        public virtual void ResetDatabaseSoftwareImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDstFileUpdateEnabled")]
        public virtual void ResetIsDstFileUpdateEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchingMode")]
        public virtual void ResetPatchingMode()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseMaintenanceRun.DatabaseMaintenanceRun))!;

        [JsiiProperty(name: "currentCustomActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentCustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentPatchingComponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentPatchingComponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedComponentPatchingStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedComponentPatchingStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedPatchingTime", typeJson: "{\"fqn\":\"oci.databaseMaintenanceRun.DatabaseMaintenanceRunEstimatedPatchingTimeList\"}")]
        public virtual oci.DatabaseMaintenanceRun.DatabaseMaintenanceRunEstimatedPatchingTimeList EstimatedPatchingTime
        {
            get => GetInstanceProperty<oci.DatabaseMaintenanceRun.DatabaseMaintenanceRunEstimatedPatchingTimeList>()!;
        }

        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCustomActionTimeoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMaintenanceRunGranular", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMaintenanceRunGranular
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceSubtype", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceSubtype
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchFailureCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PatchFailureCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingEndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerMaintenanceRunIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerMaintenanceRunIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "targetDbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetStorageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetStorageServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMaintenanceRun.DatabaseMaintenanceRunTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseMaintenanceRun.DatabaseMaintenanceRunTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseMaintenanceRun.DatabaseMaintenanceRunTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalTimeTakenInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTimeTakenInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseSoftwareImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDstFileUpdateEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDstFileUpdateEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseMaintenanceRun.DatabaseMaintenanceRunTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeScheduledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeScheduledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isDstFileUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDstFileUpdateEnabled
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

        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
