using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseMysqlConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config digitalocean_database_mysql_config}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DatabaseMysqlConfig.DatabaseMysqlConfig), fullyQualifiedName: "digitalocean.databaseMysqlConfig.DatabaseMysqlConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.databaseMysqlConfig.DatabaseMysqlConfigConfig\"}}]")]
    public class DatabaseMysqlConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config digitalocean_database_mysql_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseMysqlConfig(Constructs.Construct scope, string id, digitalocean.DatabaseMysqlConfig.IDatabaseMysqlConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DatabaseMysqlConfig.IDatabaseMysqlConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMysqlConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMysqlConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseMysqlConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseMysqlConfig to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseMysqlConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseMysqlConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseMysqlConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseMysqlConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseMysqlConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DatabaseMysqlConfig.DatabaseMysqlConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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

        [JsiiMethod(name: "resetBinlogRetentionPeriod")]
        public virtual void ResetBinlogRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectTimeout")]
        public virtual void ResetConnectTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTimeZone")]
        public virtual void ResetDefaultTimeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupConcatMaxLen")]
        public virtual void ResetGroupConcatMaxLen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInformationSchemaStatsExpiry")]
        public virtual void ResetInformationSchemaStatsExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbFtMinTokenSize")]
        public virtual void ResetInnodbFtMinTokenSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbFtServerStopwordTable")]
        public virtual void ResetInnodbFtServerStopwordTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbLockWaitTimeout")]
        public virtual void ResetInnodbLockWaitTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbLogBufferSize")]
        public virtual void ResetInnodbLogBufferSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbOnlineAlterLogMaxSize")]
        public virtual void ResetInnodbOnlineAlterLogMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbPrintAllDeadlocks")]
        public virtual void ResetInnodbPrintAllDeadlocks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInnodbRollbackOnTimeout")]
        public virtual void ResetInnodbRollbackOnTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInteractiveTimeout")]
        public virtual void ResetInteractiveTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalTmpMemStorageEngine")]
        public virtual void ResetInternalTmpMemStorageEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLongQueryTime")]
        public virtual void ResetLongQueryTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxAllowedPacket")]
        public virtual void ResetMaxAllowedPacket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHeapTableSize")]
        public virtual void ResetMaxHeapTableSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetReadTimeout")]
        public virtual void ResetNetReadTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetWriteTimeout")]
        public virtual void ResetNetWriteTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowQueryLog")]
        public virtual void ResetSlowQueryLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortBufferSize")]
        public virtual void ResetSortBufferSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlMode")]
        public virtual void ResetSqlMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlRequirePrimaryKey")]
        public virtual void ResetSqlRequirePrimaryKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTmpTableSize")]
        public virtual void ResetTmpTableSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitTimeout")]
        public virtual void ResetWaitTimeout()
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
        = GetStaticProperty<string>(typeof(digitalocean.DatabaseMysqlConfig.DatabaseMysqlConfig))!;

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
        [JsiiProperty(name: "binlogRetentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BinlogRetentionPeriodInput
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
        [JsiiProperty(name: "connectTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTimeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultTimeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupConcatMaxLenInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GroupConcatMaxLenInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "informationSchemaStatsExpiryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InformationSchemaStatsExpiryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbFtMinTokenSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InnodbFtMinTokenSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbFtServerStopwordTableInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InnodbFtServerStopwordTableInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbLockWaitTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InnodbLockWaitTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbLogBufferSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InnodbLogBufferSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbOnlineAlterLogMaxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InnodbOnlineAlterLogMaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbPrintAllDeadlocksInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InnodbPrintAllDeadlocksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "innodbRollbackOnTimeoutInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InnodbRollbackOnTimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interactiveTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InteractiveTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalTmpMemStorageEngineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InternalTmpMemStorageEngineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "longQueryTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LongQueryTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedPacketInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAllowedPacketInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHeapTableSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHeapTableSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netReadTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetReadTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netWriteTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetWriteTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowQueryLogInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SlowQueryLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortBufferSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SortBufferSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlRequirePrimaryKeyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SqlRequirePrimaryKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tmpTableSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TmpTableSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitTimeoutInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "binlogRetentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BinlogRetentionPeriod
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

        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTimeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTimeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupConcatMaxLen
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

        [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InformationSchemaStatsExpiry
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbFtMinTokenSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbFtServerStopwordTable
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbLockWaitTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbLogBufferSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbLogBufferSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbOnlineAlterLogMaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "innodbPrintAllDeadlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object InnodbPrintAllDeadlocks
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

        [JsiiProperty(name: "innodbRollbackOnTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object InnodbRollbackOnTimeout
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

        [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InteractiveTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "internalTmpMemStorageEngine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalTmpMemStorageEngine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongQueryTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAllowedPacket
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHeapTableSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetReadTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetWriteTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slowQueryLog", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SlowQueryLog
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

        [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SortBufferSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlRequirePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SqlRequirePrimaryKey
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

        [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TmpTableSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
