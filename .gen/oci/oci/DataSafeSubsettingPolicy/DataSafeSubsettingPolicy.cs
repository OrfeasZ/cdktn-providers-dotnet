using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy oci_data_safe_subsetting_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicy), fullyQualifiedName: "oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyConfig\"}}]")]
    public class DataSafeSubsettingPolicy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy oci_data_safe_subsetting_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSubsettingPolicy(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSubsettingPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSubsettingPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSubsettingPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSubsettingPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSubsettingPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSubsettingPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSubsettingPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSchemaSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSource\"}}]")]
        public virtual void PutSchemaSource(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTargetCredentials\"}}]")]
        public virtual void PutTargetCredentials(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTargetCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTargetCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCheckType")]
        public virtual void ResetCheckType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetGenerateHealthReportTrigger")]
        public virtual void ResetGenerateHealthReportTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetMaskingPolicyId")]
        public virtual void ResetMaskingPolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelDegree")]
        public virtual void ResetParallelDegree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostSubsettingScript")]
        public virtual void ResetPostSubsettingScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreSubsettingScript")]
        public virtual void ResetPreSubsettingScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecompile")]
        public virtual void ResetRecompile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablespace")]
        public virtual void ResetTablespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCredentials")]
        public virtual void ResetTargetCredentials()
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

        [JsiiMethod(name: "resetUnrelatedTablesAction")]
        public virtual void ResetUnrelatedTablesAction()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicy))!;

        [JsiiProperty(name: "schemaSource", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSourceOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSourceOutputReference SchemaSource
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSourceOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCredentials", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTargetCredentialsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicyTargetCredentialsOutputReference TargetCredentials
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicyTargetCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicy.DataSafeSubsettingPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckTypeInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "generateHealthReportTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GenerateHealthReportTriggerInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "maskingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaskingPolicyIdInput
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
        [JsiiProperty(name: "postSubsettingScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostSubsettingScriptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preSubsettingScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreSubsettingScriptInput
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
        [JsiiProperty(name: "schemaSourceInput", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSource\"}", isOptional: true)]
        public virtual oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource? SchemaSourceInput
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCredentialsInput", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTargetCredentials\"}", isOptional: true)]
        public virtual oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTargetCredentials? TargetCredentialsInput
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTargetCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicyTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unrelatedTablesActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnrelatedTablesActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "checkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "generateHealthReportTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateHealthReportTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
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

        [JsiiProperty(name: "postSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostSubsettingScript
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreSubsettingScript
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

        [JsiiProperty(name: "unrelatedTablesAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnrelatedTablesAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
