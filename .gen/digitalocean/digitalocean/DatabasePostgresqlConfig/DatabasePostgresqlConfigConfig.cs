using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigConfig")]
    public class DatabasePostgresqlConfigConfig : digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#cluster_id DatabasePostgresqlConfig#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_analyze_scale_factor DatabasePostgresqlConfig#autovacuum_analyze_scale_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumAnalyzeScaleFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumAnalyzeScaleFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_analyze_threshold DatabasePostgresqlConfig#autovacuum_analyze_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumAnalyzeThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumAnalyzeThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_freeze_max_age DatabasePostgresqlConfig#autovacuum_freeze_max_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumFreezeMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumFreezeMaxAge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_max_workers DatabasePostgresqlConfig#autovacuum_max_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumMaxWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumMaxWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_naptime DatabasePostgresqlConfig#autovacuum_naptime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumNaptime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumNaptime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_vacuum_cost_delay DatabasePostgresqlConfig#autovacuum_vacuum_cost_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumCostDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumVacuumCostDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_vacuum_cost_limit DatabasePostgresqlConfig#autovacuum_vacuum_cost_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumCostLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumVacuumCostLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_vacuum_scale_factor DatabasePostgresqlConfig#autovacuum_vacuum_scale_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumScaleFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumVacuumScaleFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autovacuum_vacuum_threshold DatabasePostgresqlConfig#autovacuum_vacuum_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autovacuumVacuumThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutovacuumVacuumThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#backup_hour DatabasePostgresqlConfig#backup_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#backup_minute DatabasePostgresqlConfig#backup_minute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupMinute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#bgwriter_delay DatabasePostgresqlConfig#bgwriter_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgwriterDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BgwriterDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#bgwriter_flush_after DatabasePostgresqlConfig#bgwriter_flush_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgwriterFlushAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BgwriterFlushAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#bgwriter_lru_maxpages DatabasePostgresqlConfig#bgwriter_lru_maxpages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgwriterLruMaxpages", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BgwriterLruMaxpages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#bgwriter_lru_multiplier DatabasePostgresqlConfig#bgwriter_lru_multiplier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgwriterLruMultiplier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BgwriterLruMultiplier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#deadlock_timeout DatabasePostgresqlConfig#deadlock_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deadlockTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeadlockTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#default_toast_compression DatabasePostgresqlConfig#default_toast_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultToastCompression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultToastCompression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#id DatabasePostgresqlConfig#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#idle_in_transaction_session_timeout DatabasePostgresqlConfig#idle_in_transaction_session_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleInTransactionSessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleInTransactionSessionTimeout
        {
            get;
            set;
        }

        private object? _jit;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#jit DatabasePostgresqlConfig#jit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Jit
        {
            get => _jit;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jit = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#log_autovacuum_min_duration DatabasePostgresqlConfig#log_autovacuum_min_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logAutovacuumMinDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogAutovacuumMinDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#log_error_verbosity DatabasePostgresqlConfig#log_error_verbosity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logErrorVerbosity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogErrorVerbosity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#log_line_prefix DatabasePostgresqlConfig#log_line_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logLinePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogLinePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#log_min_duration_statement DatabasePostgresqlConfig#log_min_duration_statement}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logMinDurationStatement", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogMinDurationStatement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_files_per_process DatabasePostgresqlConfig#max_files_per_process}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxFilesPerProcess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxFilesPerProcess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_locks_per_transaction DatabasePostgresqlConfig#max_locks_per_transaction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLocksPerTransaction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLocksPerTransaction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_logical_replication_workers DatabasePostgresqlConfig#max_logical_replication_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLogicalReplicationWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLogicalReplicationWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_parallel_workers DatabasePostgresqlConfig#max_parallel_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxParallelWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxParallelWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_parallel_workers_per_gather DatabasePostgresqlConfig#max_parallel_workers_per_gather}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxParallelWorkersPerGather", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxParallelWorkersPerGather
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_pred_locks_per_transaction DatabasePostgresqlConfig#max_pred_locks_per_transaction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPredLocksPerTransaction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPredLocksPerTransaction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_prepared_transactions DatabasePostgresqlConfig#max_prepared_transactions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPreparedTransactions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPreparedTransactions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_replication_slots DatabasePostgresqlConfig#max_replication_slots}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReplicationSlots", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReplicationSlots
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_stack_depth DatabasePostgresqlConfig#max_stack_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxStackDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxStackDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_standby_archive_delay DatabasePostgresqlConfig#max_standby_archive_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxStandbyArchiveDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxStandbyArchiveDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_standby_streaming_delay DatabasePostgresqlConfig#max_standby_streaming_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxStandbyStreamingDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxStandbyStreamingDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_wal_senders DatabasePostgresqlConfig#max_wal_senders}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWalSenders", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWalSenders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_worker_processes DatabasePostgresqlConfig#max_worker_processes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWorkerProcesses", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWorkerProcesses
        {
            get;
            set;
        }

        private object? _pgbouncer;

        /// <summary>pgbouncer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#pgbouncer DatabasePostgresqlConfig#pgbouncer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pgbouncer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigPgbouncer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pgbouncer
        {
            get => _pgbouncer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pgbouncer = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#pg_partman_bgw_interval DatabasePostgresqlConfig#pg_partman_bgw_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pgPartmanBgwInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PgPartmanBgwInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#pg_partman_bgw_role DatabasePostgresqlConfig#pg_partman_bgw_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pgPartmanBgwRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PgPartmanBgwRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#pg_stat_statements_track DatabasePostgresqlConfig#pg_stat_statements_track}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pgStatStatementsTrack", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PgStatStatementsTrack
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#shared_buffers_percentage DatabasePostgresqlConfig#shared_buffers_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sharedBuffersPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SharedBuffersPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#temp_file_limit DatabasePostgresqlConfig#temp_file_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tempFileLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TempFileLimit
        {
            get;
            set;
        }

        /// <summary>timescaledb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#timescaledb DatabasePostgresqlConfig#timescaledb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timescaledb", typeJson: "{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb\"}", isOptional: true)]
        public digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb? Timescaledb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#timezone DatabasePostgresqlConfig#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#track_activity_query_size DatabasePostgresqlConfig#track_activity_query_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trackActivityQuerySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrackActivityQuerySize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#track_commit_timestamp DatabasePostgresqlConfig#track_commit_timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trackCommitTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrackCommitTimestamp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#track_functions DatabasePostgresqlConfig#track_functions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trackFunctions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrackFunctions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#track_io_timing DatabasePostgresqlConfig#track_io_timing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trackIoTiming", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrackIoTiming
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#wal_sender_timeout DatabasePostgresqlConfig#wal_sender_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walSenderTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WalSenderTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#wal_writer_delay DatabasePostgresqlConfig#wal_writer_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walWriterDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WalWriterDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#work_mem DatabasePostgresqlConfig#work_mem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workMem", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WorkMem
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
