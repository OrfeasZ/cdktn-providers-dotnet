using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlConfigurations.DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlConfigurations.DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlConfigurationsConfigurationsVariablesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autocommit", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Autocommit
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoIncrementIncrement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoIncrementIncrement
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoIncrementOffset", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoIncrementOffset
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "bigTables", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BigTables
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "binlogExpireLogsSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BinlogExpireLogsSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "binlogGroupCommitSyncDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BinlogGroupCommitSyncDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "binlogGroupCommitSyncNoDelayCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BinlogGroupCommitSyncNoDelayCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "binlogRowMetadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinlogRowMetadata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binlogRowValueOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinlogRowValueOptions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binlogTransactionCompression", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BinlogTransactionCompression
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "blockEncryptionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockEncryptionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "characterSetServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSetServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "collationServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollationServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "completionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompletionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionMemoryChunkSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionMemoryChunkSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "connectionMemoryLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionMemoryLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cteMaxRecursionDepth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CteMaxRecursionDepth
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultAuthenticationPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultAuthenticationPlugin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "explainFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExplainFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "explicitDefaultsForTimestamp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExplicitDefaultsForTimestamp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "foreignKeyChecks", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForeignKeyChecks
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "generatedRandomPasswordLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GeneratedRandomPasswordLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "globalConnectionMemoryLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalConnectionMemoryLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "globalConnectionMemoryTracking", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable GlobalConnectionMemoryTracking
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupConcatMaxLen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupReplicationConsistency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupReplicationConsistency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InformationSchemaStatsExpiry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbAdaptiveHashIndex", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbAdaptiveHashIndex
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbAutoincLockMode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbAutoincLockMode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbBufferPoolDumpPct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbBufferPoolDumpPct
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbBufferPoolInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbBufferPoolInstances
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbBufferPoolSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbBufferPoolSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbChangeBuffering", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbChangeBuffering
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbDdlBufferSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbDdlBufferSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbDdlThreads", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbDdlThreads
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbFtEnableStopword", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbFtEnableStopword
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbFtMaxTokenSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbFtMaxTokenSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbFtMinTokenSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbFtNumWordOptimize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbFtNumWordOptimize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbFtResultCacheLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbFtResultCacheLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbFtServerStopwordTable
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbLockWaitTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbLogWriterThreads", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbLogWriterThreads
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbMaxPurgeLag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbMaxPurgeLag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbMaxPurgeLagDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbMaxPurgeLagDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbNumaInterleave", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbNumaInterleave
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbOnlineAlterLogMaxSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbRedoLogCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbRedoLogCapacity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbRollbackOnTimeout", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbRollbackOnTimeout
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbSortBufferSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InnodbSortBufferSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "innodbStatsPersistentSamplePages", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbStatsPersistentSamplePages
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbStatsTransientSamplePages", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InnodbStatsTransientSamplePages
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "innodbStrictMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbStrictMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "innodbUndoLogTruncate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InnodbUndoLogTruncate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InteractiveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "joinBufferSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JoinBufferSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localInfile", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LocalInfile
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongQueryTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mandatoryRoles", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MandatoryRoles
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAllowedPacket
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBinlogCacheSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxBinlogCacheSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxConnectErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxConnectErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxExecutionTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxExecutionTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxHeapTableSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxPreparedStmtCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPreparedStmtCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSeeksForKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxSeeksForKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxUserConnections
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mysqlFirewallMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MysqlFirewallMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mysqlxConnectTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxConnectTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxDeflateDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxDeflateDefaultCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxDeflateMaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxDeflateMaxClientCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxDocumentIdUniquePrefix", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxDocumentIdUniquePrefix
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxEnableHelloNotice", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MysqlxEnableHelloNotice
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mysqlxIdleWorkerThreadTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxIdleWorkerThreadTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxInteractiveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxInteractiveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxLz4DefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxLz4DefaultCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxLz4MaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxLz4MaxClientCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxMaxAllowedPacket", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxMaxAllowedPacket
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxMinWorkerThreads", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxMinWorkerThreads
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxReadTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxReadTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxWaitTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxWaitTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxWriteTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxWriteTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxZstdDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxZstdDefaultCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlxZstdMaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlxZstdMaxClientCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mysqlZstdDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MysqlZstdDefaultCompressionLevel
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetReadTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetWriteTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "optimizerSwitch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OptimizerSwitch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parserMaxMemSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParserMaxMemSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryAllocBlockSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryAllocBlockSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryPreallocSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryPreallocSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rangeOptimizerMaxMemSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeOptimizerMaxMemSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regexpTimeLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RegexpTimeLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "relayLogSpaceLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelayLogSpaceLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaNetTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaNetTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicaParallelWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaParallelWorkers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicaTypeConversions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaTypeConversions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireSecureTransport", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireSecureTransport
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "skipNameResolve", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SkipNameResolve
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortBufferSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlGenerateInvisiblePrimaryKey", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SqlGenerateInvisiblePrimaryKey
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlRequirePrimaryKey", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SqlRequirePrimaryKey
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sqlWarnings", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SqlWarnings
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tableDefinitionCache", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TableDefinitionCache
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tableOpenCache", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TableOpenCache
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "temptableMaxRam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemptableMaxRam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threadPoolDedicatedListeners", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ThreadPoolDedicatedListeners
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "threadPoolMaxTransactionsLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolMaxTransactionsLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "threadPoolQueryThreadsPerGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolQueryThreadsPerGroup
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "threadPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "threadPoolTransactionDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadPoolTransactionDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TmpTableSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionIsolation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionIsolation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlConfigurations.DataOciMysqlMysqlConfigurationsConfigurationsVariables\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlConfigurations.IDataOciMysqlMysqlConfigurationsConfigurationsVariables? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlConfigurations.IDataOciMysqlMysqlConfigurationsConfigurationsVariables?>();
            set => SetInstanceProperty(value);
        }
    }
}
