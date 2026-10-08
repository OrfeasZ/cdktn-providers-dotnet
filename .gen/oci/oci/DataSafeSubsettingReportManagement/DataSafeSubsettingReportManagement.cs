using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingReportManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_report_management oci_data_safe_subsetting_report_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagement), fullyQualifiedName: "oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementConfig\"}}]")]
    public class DataSafeSubsettingReportManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_report_management oci_data_safe_subsetting_report_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSubsettingReportManagement(Constructs.Construct scope, string id, oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingReportManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingReportManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSubsettingReportManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSubsettingReportManagement to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSubsettingReportManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSubsettingReportManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSubsettingReportManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_report_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSubsettingReportManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSubsettingReportManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTargetCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentials\"}}]")]
        public virtual void PutTargetCredentials(oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRedoLoggingEnabled")]
        public virtual void ResetIsRedoLoggingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRefreshStatsEnabled")]
        public virtual void ResetIsRefreshStatsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRerun")]
        public virtual void ResetIsRerun()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasking")]
        public virtual void ResetMasking()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelDegree")]
        public virtual void ResetParallelDegree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecompile")]
        public virtual void ResetRecompile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReRunFromStep")]
        public virtual void ResetReRunFromStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablespace")]
        public virtual void ResetTablespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagement))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSizeAfterSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSizeAfterSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSizeBeforeSubsettingInKbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSizeBeforeSubsettingInKbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingReportId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingReportId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subsettingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCredentials", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentialsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentialsOutputReference TargetCredentials
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeSubsettingFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSubsettingFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSubsettingStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSubsettingStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPostSubsettingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPostSubsettingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPreSubsettingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPreSubsettingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedObjects
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedRows", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedRows
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSubsettedSchemas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSubsettedSchemas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRedoLoggingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRedoLoggingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRefreshStatsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRefreshStatsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRerunInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRerunInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maskingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaskingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelDegreeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParallelDegreeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recompileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecompileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reRunFromStepInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReRunFromStepInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCredentialsInput", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentials\"}", isOptional: true)]
        public virtual oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials? TargetCredentialsInput
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRedoLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRedoLoggingEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRefreshStatsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRefreshStatsEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRerun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRerun
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

        [JsiiProperty(name: "masking", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Masking
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parallelDegree", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParallelDegree
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recompile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recompile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reRunFromStep", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReRunFromStep
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tablespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
