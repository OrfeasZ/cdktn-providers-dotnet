using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseOpensearchConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_opensearch_config digitalocean_database_opensearch_config}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DatabaseOpensearchConfig.DatabaseOpensearchConfig), fullyQualifiedName: "digitalocean.databaseOpensearchConfig.DatabaseOpensearchConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.databaseOpensearchConfig.DatabaseOpensearchConfigConfig\"}}]")]
    public class DatabaseOpensearchConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_opensearch_config digitalocean_database_opensearch_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseOpensearchConfig(Constructs.Construct scope, string id, digitalocean.DatabaseOpensearchConfig.IDatabaseOpensearchConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DatabaseOpensearchConfig.IDatabaseOpensearchConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseOpensearchConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseOpensearchConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseOpensearchConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseOpensearchConfig to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseOpensearchConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseOpensearchConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseOpensearchConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_opensearch_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseOpensearchConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseOpensearchConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DatabaseOpensearchConfig.DatabaseOpensearchConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetActionAutoCreateIndexEnabled")]
        public virtual void ResetActionAutoCreateIndexEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActionDestructiveRequiresName")]
        public virtual void ResetActionDestructiveRequiresName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterMaxShardsPerNode")]
        public virtual void ResetClusterMaxShardsPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterRoutingAllocationNodeConcurrentRecoveries")]
        public virtual void ResetClusterRoutingAllocationNodeConcurrentRecoveries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSecurityAudit")]
        public virtual void ResetEnableSecurityAudit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpMaxContentLengthBytes")]
        public virtual void ResetHttpMaxContentLengthBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpMaxHeaderSizeBytes")]
        public virtual void ResetHttpMaxHeaderSizeBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpMaxInitialLineLengthBytes")]
        public virtual void ResetHttpMaxInitialLineLengthBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesFielddataCacheSizePercentage")]
        public virtual void ResetIndicesFielddataCacheSizePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesMemoryIndexBufferSizePercentage")]
        public virtual void ResetIndicesMemoryIndexBufferSizePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesMemoryMaxIndexBufferSizeMb")]
        public virtual void ResetIndicesMemoryMaxIndexBufferSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesMemoryMinIndexBufferSizeMb")]
        public virtual void ResetIndicesMemoryMinIndexBufferSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesQueriesCacheSizePercentage")]
        public virtual void ResetIndicesQueriesCacheSizePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesQueryBoolMaxClauseCount")]
        public virtual void ResetIndicesQueryBoolMaxClauseCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesRecoveryMaxConcurrentFileChunks")]
        public virtual void ResetIndicesRecoveryMaxConcurrentFileChunks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndicesRecoveryMaxMbPerSec")]
        public virtual void ResetIndicesRecoveryMaxMbPerSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmEnabled")]
        public virtual void ResetIsmEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmHistoryEnabled")]
        public virtual void ResetIsmHistoryEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmHistoryMaxAgeHours")]
        public virtual void ResetIsmHistoryMaxAgeHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmHistoryMaxDocs")]
        public virtual void ResetIsmHistoryMaxDocs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmHistoryRolloverCheckPeriodHours")]
        public virtual void ResetIsmHistoryRolloverCheckPeriodHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsmHistoryRolloverRetentionPeriodDays")]
        public virtual void ResetIsmHistoryRolloverRetentionPeriodDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideMainResponseVersion")]
        public virtual void ResetOverrideMainResponseVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsAlertingFilterByBackendRolesEnabled")]
        public virtual void ResetPluginsAlertingFilterByBackendRolesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReindexRemoteWhitelist")]
        public virtual void ResetReindexRemoteWhitelist()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptMaxCompilationsRate")]
        public virtual void ResetScriptMaxCompilationsRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchMaxBuckets")]
        public virtual void ResetSearchMaxBuckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolAnalyzeQueueSize")]
        public virtual void ResetThreadPoolAnalyzeQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolAnalyzeSize")]
        public virtual void ResetThreadPoolAnalyzeSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolForceMergeSize")]
        public virtual void ResetThreadPoolForceMergeSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolGetQueueSize")]
        public virtual void ResetThreadPoolGetQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolGetSize")]
        public virtual void ResetThreadPoolGetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolSearchQueueSize")]
        public virtual void ResetThreadPoolSearchQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolSearchSize")]
        public virtual void ResetThreadPoolSearchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolSearchThrottledQueueSize")]
        public virtual void ResetThreadPoolSearchThrottledQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolSearchThrottledSize")]
        public virtual void ResetThreadPoolSearchThrottledSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolWriteQueueSize")]
        public virtual void ResetThreadPoolWriteQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadPoolWriteSize")]
        public virtual void ResetThreadPoolWriteSize()
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
        = GetStaticProperty<string>(typeof(digitalocean.DatabaseOpensearchConfig.DatabaseOpensearchConfig))!;

        [JsiiOptional]
        [JsiiProperty(name: "actionAutoCreateIndexEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActionAutoCreateIndexEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionDestructiveRequiresNameInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActionDestructiveRequiresNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterMaxShardsPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClusterMaxShardsPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterRoutingAllocationNodeConcurrentRecoveriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClusterRoutingAllocationNodeConcurrentRecoveriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSecurityAuditInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableSecurityAuditInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMaxContentLengthBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpMaxContentLengthBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMaxHeaderSizeBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpMaxHeaderSizeBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMaxInitialLineLengthBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpMaxInitialLineLengthBytesInput
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
        [JsiiProperty(name: "indicesFielddataCacheSizePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesFielddataCacheSizePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryIndexBufferSizePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesMemoryIndexBufferSizePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryMaxIndexBufferSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesMemoryMaxIndexBufferSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryMinIndexBufferSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesMemoryMinIndexBufferSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesQueriesCacheSizePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesQueriesCacheSizePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesQueryBoolMaxClauseCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesQueryBoolMaxClauseCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesRecoveryMaxConcurrentFileChunksInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesRecoveryMaxConcurrentFileChunksInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indicesRecoveryMaxMbPerSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndicesRecoveryMaxMbPerSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsmEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsmHistoryEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryMaxAgeHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IsmHistoryMaxAgeHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryMaxDocsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IsmHistoryMaxDocsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryRolloverCheckPeriodHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IsmHistoryRolloverCheckPeriodHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryRolloverRetentionPeriodDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IsmHistoryRolloverRetentionPeriodDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideMainResponseVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OverrideMainResponseVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsAlertingFilterByBackendRolesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PluginsAlertingFilterByBackendRolesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reindexRemoteWhitelistInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ReindexRemoteWhitelistInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptMaxCompilationsRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptMaxCompilationsRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchMaxBucketsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SearchMaxBucketsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolAnalyzeQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolAnalyzeQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolAnalyzeSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolAnalyzeSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolForceMergeSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolForceMergeSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolGetQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolGetQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolGetSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolGetSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolSearchQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolSearchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchThrottledQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolSearchThrottledQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchThrottledSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolSearchThrottledSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolWriteQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolWriteQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadPoolWriteSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadPoolWriteSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "actionAutoCreateIndexEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ActionAutoCreateIndexEnabled
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

        [JsiiProperty(name: "actionDestructiveRequiresName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ActionDestructiveRequiresName
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

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterMaxShardsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClusterMaxShardsPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterRoutingAllocationNodeConcurrentRecoveries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClusterRoutingAllocationNodeConcurrentRecoveries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableSecurityAudit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableSecurityAudit
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

        [JsiiProperty(name: "httpMaxContentLengthBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpMaxContentLengthBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMaxHeaderSizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpMaxHeaderSizeBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMaxInitialLineLengthBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpMaxInitialLineLengthBytes
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

        [JsiiProperty(name: "indicesFielddataCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesFielddataCacheSizePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesMemoryIndexBufferSizePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesMemoryIndexBufferSizePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesMemoryMaxIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesMemoryMaxIndexBufferSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesMemoryMinIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesMemoryMinIndexBufferSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesQueriesCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesQueriesCacheSizePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesQueryBoolMaxClauseCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesQueryBoolMaxClauseCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesRecoveryMaxConcurrentFileChunks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesRecoveryMaxConcurrentFileChunks
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indicesRecoveryMaxMbPerSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IndicesRecoveryMaxMbPerSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ismEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsmEnabled
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

        [JsiiProperty(name: "ismHistoryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsmHistoryEnabled
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

        [JsiiProperty(name: "ismHistoryMaxAgeHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IsmHistoryMaxAgeHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ismHistoryMaxDocs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IsmHistoryMaxDocs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ismHistoryRolloverCheckPeriodHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IsmHistoryRolloverCheckPeriodHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ismHistoryRolloverRetentionPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IsmHistoryRolloverRetentionPeriodDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overrideMainResponseVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object OverrideMainResponseVersion
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

        [JsiiProperty(name: "pluginsAlertingFilterByBackendRolesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PluginsAlertingFilterByBackendRolesEnabled
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

        [JsiiProperty(name: "reindexRemoteWhitelist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReindexRemoteWhitelist
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scriptMaxCompilationsRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptMaxCompilationsRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchMaxBuckets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchMaxBuckets
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolAnalyzeQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolAnalyzeQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolAnalyzeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolAnalyzeSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolForceMergeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolForceMergeSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolGetQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolGetQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolGetSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolGetSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolSearchQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolSearchQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolSearchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolSearchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolSearchThrottledQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolSearchThrottledQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolSearchThrottledSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolSearchThrottledSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolWriteQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolWriteQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadPoolWriteSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolWriteSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
