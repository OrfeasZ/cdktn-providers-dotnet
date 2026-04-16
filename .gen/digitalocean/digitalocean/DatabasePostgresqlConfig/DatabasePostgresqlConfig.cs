using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_postgresql_config digitalocean_database_postgresql_config}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfig), fullyQualifiedName: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigConfig\"}}]")]
    public class DatabasePostgresqlConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_postgresql_config digitalocean_database_postgresql_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabasePostgresqlConfig(Constructs.Construct scope, string id, digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePostgresqlConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePostgresqlConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabasePostgresqlConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabasePostgresqlConfig to import.</param>
        /// <param name="importFromId">The id of the existing DatabasePostgresqlConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabasePostgresqlConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabasePostgresqlConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_postgresql_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabasePostgresqlConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabasePostgresqlConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPgbouncer", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigPgbouncer\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPgbouncer(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimescaledb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb\"}}]")]
        public virtual void PutTimescaledb(digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutovacuumAnalyzeScaleFactor")]
        public virtual void ResetAutovacuumAnalyzeScaleFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumAnalyzeThreshold")]
        public virtual void ResetAutovacuumAnalyzeThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumFreezeMaxAge")]
        public virtual void ResetAutovacuumFreezeMaxAge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumMaxWorkers")]
        public virtual void ResetAutovacuumMaxWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumNaptime")]
        public virtual void ResetAutovacuumNaptime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumVacuumCostDelay")]
        public virtual void ResetAutovacuumVacuumCostDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumVacuumCostLimit")]
        public virtual void ResetAutovacuumVacuumCostLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumVacuumScaleFactor")]
        public virtual void ResetAutovacuumVacuumScaleFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutovacuumVacuumThreshold")]
        public virtual void ResetAutovacuumVacuumThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupHour")]
        public virtual void ResetBackupHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupMinute")]
        public virtual void ResetBackupMinute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgwriterDelay")]
        public virtual void ResetBgwriterDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgwriterFlushAfter")]
        public virtual void ResetBgwriterFlushAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgwriterLruMaxpages")]
        public virtual void ResetBgwriterLruMaxpages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgwriterLruMultiplier")]
        public virtual void ResetBgwriterLruMultiplier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadlockTimeout")]
        public virtual void ResetDeadlockTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultToastCompression")]
        public virtual void ResetDefaultToastCompression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdleInTransactionSessionTimeout")]
        public virtual void ResetIdleInTransactionSessionTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJit")]
        public virtual void ResetJit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogAutovacuumMinDuration")]
        public virtual void ResetLogAutovacuumMinDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogErrorVerbosity")]
        public virtual void ResetLogErrorVerbosity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogLinePrefix")]
        public virtual void ResetLogLinePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogMinDurationStatement")]
        public virtual void ResetLogMinDurationStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxFilesPerProcess")]
        public virtual void ResetMaxFilesPerProcess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxLocksPerTransaction")]
        public virtual void ResetMaxLocksPerTransaction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxLogicalReplicationWorkers")]
        public virtual void ResetMaxLogicalReplicationWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxParallelWorkers")]
        public virtual void ResetMaxParallelWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxParallelWorkersPerGather")]
        public virtual void ResetMaxParallelWorkersPerGather()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPredLocksPerTransaction")]
        public virtual void ResetMaxPredLocksPerTransaction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPreparedTransactions")]
        public virtual void ResetMaxPreparedTransactions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxReplicationSlots")]
        public virtual void ResetMaxReplicationSlots()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxStackDepth")]
        public virtual void ResetMaxStackDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxStandbyArchiveDelay")]
        public virtual void ResetMaxStandbyArchiveDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxStandbyStreamingDelay")]
        public virtual void ResetMaxStandbyStreamingDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWalSenders")]
        public virtual void ResetMaxWalSenders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWorkerProcesses")]
        public virtual void ResetMaxWorkerProcesses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPgbouncer")]
        public virtual void ResetPgbouncer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPgPartmanBgwInterval")]
        public virtual void ResetPgPartmanBgwInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPgPartmanBgwRole")]
        public virtual void ResetPgPartmanBgwRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPgStatStatementsTrack")]
        public virtual void ResetPgStatStatementsTrack()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedBuffersPercentage")]
        public virtual void ResetSharedBuffersPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTempFileLimit")]
        public virtual void ResetTempFileLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimescaledb")]
        public virtual void ResetTimescaledb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackActivityQuerySize")]
        public virtual void ResetTrackActivityQuerySize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackCommitTimestamp")]
        public virtual void ResetTrackCommitTimestamp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackFunctions")]
        public virtual void ResetTrackFunctions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackIoTiming")]
        public virtual void ResetTrackIoTiming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWalSenderTimeout")]
        public virtual void ResetWalSenderTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWalWriterDelay")]
        public virtual void ResetWalWriterDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkMem")]
        public virtual void ResetWorkMem()
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
        = GetStaticProperty<string>(typeof(digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfig))!;

        [JsiiProperty(name: "pgbouncer", typeJson: "{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigPgbouncerList\"}")]
        public virtual digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfigPgbouncerList Pgbouncer
        {
            get => GetInstanceProperty<digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfigPgbouncerList>()!;
        }

        [JsiiProperty(name: "timescaledb", typeJson: "{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledbOutputReference\"}")]
        public virtual digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfigTimescaledbOutputReference Timescaledb
        {
            get => GetInstanceProperty<digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfigTimescaledbOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumAnalyzeScaleFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumAnalyzeScaleFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumAnalyzeThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumAnalyzeThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumFreezeMaxAgeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumFreezeMaxAgeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumMaxWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumMaxWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumNaptimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumNaptimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumCostDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumVacuumCostDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumCostLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumVacuumCostLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumScaleFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumVacuumScaleFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutovacuumVacuumThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupMinuteInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupMinuteInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgwriterDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BgwriterDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgwriterFlushAfterInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BgwriterFlushAfterInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgwriterLruMaxpagesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BgwriterLruMaxpagesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgwriterLruMultiplierInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BgwriterLruMultiplierInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadlockTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeadlockTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultToastCompressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultToastCompressionInput
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
        [JsiiProperty(name: "idleInTransactionSessionTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IdleInTransactionSessionTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logAutovacuumMinDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogAutovacuumMinDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logErrorVerbosityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogErrorVerbosityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logLinePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogLinePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logMinDurationStatementInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogMinDurationStatementInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxFilesPerProcessInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxFilesPerProcessInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxLocksPerTransactionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxLocksPerTransactionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxLogicalReplicationWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxLogicalReplicationWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxParallelWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxParallelWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxParallelWorkersPerGatherInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxParallelWorkersPerGatherInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPredLocksPerTransactionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPredLocksPerTransactionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPreparedTransactionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPreparedTransactionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxReplicationSlotsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxReplicationSlotsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxStackDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxStackDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxStandbyArchiveDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxStandbyArchiveDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxStandbyStreamingDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxStandbyStreamingDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWalSendersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWalSendersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWorkerProcessesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWorkerProcessesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgbouncerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigPgbouncer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PgbouncerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgPartmanBgwIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PgPartmanBgwIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgPartmanBgwRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PgPartmanBgwRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgStatStatementsTrackInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PgStatStatementsTrackInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedBuffersPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SharedBuffersPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tempFileLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TempFileLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timescaledbInput", typeJson: "{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb\"}", isOptional: true)]
        public virtual digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb? TimescaledbInput
        {
            get => GetInstanceProperty<digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackActivityQuerySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TrackActivityQuerySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackCommitTimestampInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrackCommitTimestampInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackFunctionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrackFunctionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackIoTimingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrackIoTimingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walSenderTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WalSenderTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walWriterDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WalWriterDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workMemInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WorkMemInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "autovacuumAnalyzeScaleFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumAnalyzeScaleFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumAnalyzeThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumAnalyzeThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumFreezeMaxAge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumFreezeMaxAge
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumMaxWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumMaxWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumNaptime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumNaptime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumVacuumCostDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumVacuumCostDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumVacuumCostLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumVacuumCostLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumVacuumScaleFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumVacuumScaleFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autovacuumVacuumThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutovacuumVacuumThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupMinute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupMinute
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgwriterDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgwriterDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgwriterFlushAfter", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgwriterFlushAfter
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgwriterLruMaxpages", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgwriterLruMaxpages
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgwriterLruMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgwriterLruMultiplier
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deadlockTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeadlockTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultToastCompression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultToastCompression
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

        [JsiiProperty(name: "idleInTransactionSessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdleInTransactionSessionTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Jit
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

        [JsiiProperty(name: "logAutovacuumMinDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogAutovacuumMinDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logErrorVerbosity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogErrorVerbosity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logLinePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogLinePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logMinDurationStatement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogMinDurationStatement
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxFilesPerProcess", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFilesPerProcess
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxLocksPerTransaction", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLocksPerTransaction
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxLogicalReplicationWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxLogicalReplicationWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxParallelWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxParallelWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxParallelWorkersPerGather", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxParallelWorkersPerGather
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPredLocksPerTransaction", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPredLocksPerTransaction
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPreparedTransactions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPreparedTransactions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxReplicationSlots", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplicationSlots
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxStackDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStackDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxStandbyArchiveDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStandbyArchiveDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxStandbyStreamingDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStandbyStreamingDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWalSenders", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWalSenders
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWorkerProcesses", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWorkerProcesses
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgPartmanBgwInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PgPartmanBgwInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgPartmanBgwRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PgPartmanBgwRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgStatStatementsTrack", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PgStatStatementsTrack
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sharedBuffersPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SharedBuffersPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tempFileLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TempFileLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trackActivityQuerySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrackActivityQuerySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trackCommitTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackCommitTimestamp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trackFunctions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackFunctions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trackIoTiming", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackIoTiming
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walSenderTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WalSenderTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walWriterDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WalWriterDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workMem", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkMem
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
