using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    [JsiiByValue(fqn: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationVariables")]
    public class MysqlMysqlConfigurationVariables : oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationVariables
    {
        private object? _autocommit;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#autocommit MysqlMysqlConfiguration#autocommit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autocommit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Autocommit
        {
            get => _autocommit;
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
                _autocommit = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#auto_increment_increment MysqlMysqlConfiguration#auto_increment_increment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoIncrementIncrement", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoIncrementIncrement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#auto_increment_offset MysqlMysqlConfiguration#auto_increment_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoIncrementOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoIncrementOffset
        {
            get;
            set;
        }

        private object? _bigTables;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#big_tables MysqlMysqlConfiguration#big_tables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bigTables", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BigTables
        {
            get => _bigTables;
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
                _bigTables = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_expire_logs_seconds MysqlMysqlConfiguration#binlog_expire_logs_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogExpireLogsSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BinlogExpireLogsSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_group_commit_sync_delay MysqlMysqlConfiguration#binlog_group_commit_sync_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogGroupCommitSyncDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BinlogGroupCommitSyncDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_group_commit_sync_no_delay_count MysqlMysqlConfiguration#binlog_group_commit_sync_no_delay_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogGroupCommitSyncNoDelayCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BinlogGroupCommitSyncNoDelayCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_row_metadata MysqlMysqlConfiguration#binlog_row_metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogRowMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BinlogRowMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_row_value_options MysqlMysqlConfiguration#binlog_row_value_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogRowValueOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BinlogRowValueOptions
        {
            get;
            set;
        }

        private object? _binlogTransactionCompression;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#binlog_transaction_compression MysqlMysqlConfiguration#binlog_transaction_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogTransactionCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BinlogTransactionCompression
        {
            get => _binlogTransactionCompression;
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
                _binlogTransactionCompression = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#block_encryption_mode MysqlMysqlConfiguration#block_encryption_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockEncryptionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#character_set_server MysqlMysqlConfiguration#character_set_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "characterSetServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CharacterSetServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#collation_server MysqlMysqlConfiguration#collation_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collationServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollationServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#completion_type MysqlMysqlConfiguration#completion_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "completionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompletionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#connection_memory_chunk_size MysqlMysqlConfiguration#connection_memory_chunk_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionMemoryChunkSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionMemoryChunkSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#connection_memory_limit MysqlMysqlConfiguration#connection_memory_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionMemoryLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionMemoryLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#connect_timeout MysqlMysqlConfiguration#connect_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#cte_max_recursion_depth MysqlMysqlConfiguration#cte_max_recursion_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cteMaxRecursionDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CteMaxRecursionDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#default_authentication_plugin MysqlMysqlConfiguration#default_authentication_plugin}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAuthenticationPlugin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAuthenticationPlugin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#explain_format MysqlMysqlConfiguration#explain_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "explainFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExplainFormat
        {
            get;
            set;
        }

        private object? _explicitDefaultsForTimestamp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#explicit_defaults_for_timestamp MysqlMysqlConfiguration#explicit_defaults_for_timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "explicitDefaultsForTimestamp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExplicitDefaultsForTimestamp
        {
            get => _explicitDefaultsForTimestamp;
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
                _explicitDefaultsForTimestamp = value;
            }
        }

        private object? _foreignKeyChecks;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#foreign_key_checks MysqlMysqlConfiguration#foreign_key_checks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "foreignKeyChecks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ForeignKeyChecks
        {
            get => _foreignKeyChecks;
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
                _foreignKeyChecks = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#generated_random_password_length MysqlMysqlConfiguration#generated_random_password_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generatedRandomPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GeneratedRandomPasswordLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#global_connection_memory_limit MysqlMysqlConfiguration#global_connection_memory_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalConnectionMemoryLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GlobalConnectionMemoryLimit
        {
            get;
            set;
        }

        private object? _globalConnectionMemoryTracking;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#global_connection_memory_tracking MysqlMysqlConfiguration#global_connection_memory_tracking}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalConnectionMemoryTracking", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? GlobalConnectionMemoryTracking
        {
            get => _globalConnectionMemoryTracking;
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
                _globalConnectionMemoryTracking = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#group_concat_max_len MysqlMysqlConfiguration#group_concat_max_len}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupConcatMaxLen
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#group_replication_consistency MysqlMysqlConfiguration#group_replication_consistency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupReplicationConsistency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupReplicationConsistency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#information_schema_stats_expiry MysqlMysqlConfiguration#information_schema_stats_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InformationSchemaStatsExpiry
        {
            get;
            set;
        }

        private object? _innodbAdaptiveHashIndex;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_adaptive_hash_index MysqlMysqlConfiguration#innodb_adaptive_hash_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbAdaptiveHashIndex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbAdaptiveHashIndex
        {
            get => _innodbAdaptiveHashIndex;
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
                _innodbAdaptiveHashIndex = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_autoinc_lock_mode MysqlMysqlConfiguration#innodb_autoinc_lock_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbAutoincLockMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbAutoincLockMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_buffer_pool_dump_pct MysqlMysqlConfiguration#innodb_buffer_pool_dump_pct}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbBufferPoolDumpPct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbBufferPoolDumpPct
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_buffer_pool_instances MysqlMysqlConfiguration#innodb_buffer_pool_instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbBufferPoolInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbBufferPoolInstances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_buffer_pool_size MysqlMysqlConfiguration#innodb_buffer_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbBufferPoolSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbBufferPoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_change_buffering MysqlMysqlConfiguration#innodb_change_buffering}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbChangeBuffering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbChangeBuffering
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ddl_buffer_size MysqlMysqlConfiguration#innodb_ddl_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbDdlBufferSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbDdlBufferSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ddl_threads MysqlMysqlConfiguration#innodb_ddl_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbDdlThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbDdlThreads
        {
            get;
            set;
        }

        private object? _innodbFtEnableStopword;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_enable_stopword MysqlMysqlConfiguration#innodb_ft_enable_stopword}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtEnableStopword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbFtEnableStopword
        {
            get => _innodbFtEnableStopword;
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
                _innodbFtEnableStopword = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_max_token_size MysqlMysqlConfiguration#innodb_ft_max_token_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtMaxTokenSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbFtMaxTokenSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_min_token_size MysqlMysqlConfiguration#innodb_ft_min_token_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbFtMinTokenSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_num_word_optimize MysqlMysqlConfiguration#innodb_ft_num_word_optimize}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtNumWordOptimize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbFtNumWordOptimize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_result_cache_limit MysqlMysqlConfiguration#innodb_ft_result_cache_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtResultCacheLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbFtResultCacheLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_ft_server_stopword_table MysqlMysqlConfiguration#innodb_ft_server_stopword_table}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbFtServerStopwordTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_lock_wait_timeout MysqlMysqlConfiguration#innodb_lock_wait_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbLockWaitTimeout
        {
            get;
            set;
        }

        private object? _innodbLogWriterThreads;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_log_writer_threads MysqlMysqlConfiguration#innodb_log_writer_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbLogWriterThreads", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbLogWriterThreads
        {
            get => _innodbLogWriterThreads;
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
                _innodbLogWriterThreads = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_max_purge_lag MysqlMysqlConfiguration#innodb_max_purge_lag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbMaxPurgeLag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbMaxPurgeLag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_max_purge_lag_delay MysqlMysqlConfiguration#innodb_max_purge_lag_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbMaxPurgeLagDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbMaxPurgeLagDelay
        {
            get;
            set;
        }

        private object? _innodbNumaInterleave;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_numa_interleave MysqlMysqlConfiguration#innodb_numa_interleave}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbNumaInterleave", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbNumaInterleave
        {
            get => _innodbNumaInterleave;
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
                _innodbNumaInterleave = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_online_alter_log_max_size MysqlMysqlConfiguration#innodb_online_alter_log_max_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbOnlineAlterLogMaxSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_redo_log_capacity MysqlMysqlConfiguration#innodb_redo_log_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbRedoLogCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbRedoLogCapacity
        {
            get;
            set;
        }

        private object? _innodbRollbackOnTimeout;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_rollback_on_timeout MysqlMysqlConfiguration#innodb_rollback_on_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbRollbackOnTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbRollbackOnTimeout
        {
            get => _innodbRollbackOnTimeout;
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
                _innodbRollbackOnTimeout = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_sort_buffer_size MysqlMysqlConfiguration#innodb_sort_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbSortBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbSortBufferSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_stats_persistent_sample_pages MysqlMysqlConfiguration#innodb_stats_persistent_sample_pages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbStatsPersistentSamplePages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbStatsPersistentSamplePages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_stats_transient_sample_pages MysqlMysqlConfiguration#innodb_stats_transient_sample_pages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbStatsTransientSamplePages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbStatsTransientSamplePages
        {
            get;
            set;
        }

        private object? _innodbStrictMode;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_strict_mode MysqlMysqlConfiguration#innodb_strict_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbStrictMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbStrictMode
        {
            get => _innodbStrictMode;
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
                _innodbStrictMode = value;
            }
        }

        private object? _innodbUndoLogTruncate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#innodb_undo_log_truncate MysqlMysqlConfiguration#innodb_undo_log_truncate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbUndoLogTruncate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbUndoLogTruncate
        {
            get => _innodbUndoLogTruncate;
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
                _innodbUndoLogTruncate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#interactive_timeout MysqlMysqlConfiguration#interactive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InteractiveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#join_buffer_size MysqlMysqlConfiguration#join_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "joinBufferSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JoinBufferSize
        {
            get;
            set;
        }

        private object? _localInfile;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#local_infile MysqlMysqlConfiguration#local_infile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localInfile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? LocalInfile
        {
            get => _localInfile;
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
                _localInfile = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#long_query_time MysqlMysqlConfiguration#long_query_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongQueryTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mandatory_roles MysqlMysqlConfiguration#mandatory_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandatoryRoles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MandatoryRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_allowed_packet MysqlMysqlConfiguration#max_allowed_packet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllowedPacket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_binlog_cache_size MysqlMysqlConfiguration#max_binlog_cache_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBinlogCacheSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxBinlogCacheSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_connect_errors MysqlMysqlConfiguration#max_connect_errors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnectErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxConnectErrors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_connections MysqlMysqlConfiguration#max_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_execution_time MysqlMysqlConfiguration#max_execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxExecutionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_heap_table_size MysqlMysqlConfiguration#max_heap_table_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxHeapTableSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_prepared_stmt_count MysqlMysqlConfiguration#max_prepared_stmt_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPreparedStmtCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPreparedStmtCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_seeks_for_key MysqlMysqlConfiguration#max_seeks_for_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSeeksForKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxSeeksForKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#max_user_connections MysqlMysqlConfiguration#max_user_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxUserConnections
        {
            get;
            set;
        }

        private object? _mysqlFirewallMode;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysql_firewall_mode MysqlMysqlConfiguration#mysql_firewall_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlFirewallMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MysqlFirewallMode
        {
            get => _mysqlFirewallMode;
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
                _mysqlFirewallMode = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_connect_timeout MysqlMysqlConfiguration#mysqlx_connect_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxConnectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxConnectTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_deflate_default_compression_level MysqlMysqlConfiguration#mysqlx_deflate_default_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxDeflateDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxDeflateDefaultCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_deflate_max_client_compression_level MysqlMysqlConfiguration#mysqlx_deflate_max_client_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxDeflateMaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxDeflateMaxClientCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_document_id_unique_prefix MysqlMysqlConfiguration#mysqlx_document_id_unique_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxDocumentIdUniquePrefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxDocumentIdUniquePrefix
        {
            get;
            set;
        }

        private object? _mysqlxEnableHelloNotice;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_enable_hello_notice MysqlMysqlConfiguration#mysqlx_enable_hello_notice}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxEnableHelloNotice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MysqlxEnableHelloNotice
        {
            get => _mysqlxEnableHelloNotice;
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
                _mysqlxEnableHelloNotice = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_idle_worker_thread_timeout MysqlMysqlConfiguration#mysqlx_idle_worker_thread_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxIdleWorkerThreadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxIdleWorkerThreadTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_interactive_timeout MysqlMysqlConfiguration#mysqlx_interactive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxInteractiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxInteractiveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_lz4default_compression_level MysqlMysqlConfiguration#mysqlx_lz4default_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxLz4DefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxLz4DefaultCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_lz4max_client_compression_level MysqlMysqlConfiguration#mysqlx_lz4max_client_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxLz4MaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxLz4MaxClientCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_max_allowed_packet MysqlMysqlConfiguration#mysqlx_max_allowed_packet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxMaxAllowedPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxMaxAllowedPacket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_min_worker_threads MysqlMysqlConfiguration#mysqlx_min_worker_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxMinWorkerThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxMinWorkerThreads
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_read_timeout MysqlMysqlConfiguration#mysqlx_read_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxReadTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_wait_timeout MysqlMysqlConfiguration#mysqlx_wait_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxWaitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxWaitTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_write_timeout MysqlMysqlConfiguration#mysqlx_write_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxWriteTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxWriteTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_zstd_default_compression_level MysqlMysqlConfiguration#mysqlx_zstd_default_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxZstdDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxZstdDefaultCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysqlx_zstd_max_client_compression_level MysqlMysqlConfiguration#mysqlx_zstd_max_client_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlxZstdMaxClientCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlxZstdMaxClientCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#mysql_zstd_default_compression_level MysqlMysqlConfiguration#mysql_zstd_default_compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlZstdDefaultCompressionLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MysqlZstdDefaultCompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#net_read_timeout MysqlMysqlConfiguration#net_read_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetReadTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#net_write_timeout MysqlMysqlConfiguration#net_write_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetWriteTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#optimizer_switch MysqlMysqlConfiguration#optimizer_switch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optimizerSwitch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OptimizerSwitch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#parser_max_mem_size MysqlMysqlConfiguration#parser_max_mem_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parserMaxMemSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParserMaxMemSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#query_alloc_block_size MysqlMysqlConfiguration#query_alloc_block_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryAllocBlockSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryAllocBlockSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#query_prealloc_size MysqlMysqlConfiguration#query_prealloc_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryPreallocSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryPreallocSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#range_optimizer_max_mem_size MysqlMysqlConfiguration#range_optimizer_max_mem_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeOptimizerMaxMemSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeOptimizerMaxMemSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#regexp_time_limit MysqlMysqlConfiguration#regexp_time_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexpTimeLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RegexpTimeLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#relay_log_space_limit MysqlMysqlConfiguration#relay_log_space_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relayLogSpaceLimit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelayLogSpaceLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#replica_net_timeout MysqlMysqlConfiguration#replica_net_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaNetTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaNetTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#replica_parallel_workers MysqlMysqlConfiguration#replica_parallel_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaParallelWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaParallelWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#replica_type_conversions MysqlMysqlConfiguration#replica_type_conversions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaTypeConversions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicaTypeConversions
        {
            get;
            set;
        }

        private object? _requireSecureTransport;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#require_secure_transport MysqlMysqlConfiguration#require_secure_transport}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireSecureTransport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequireSecureTransport
        {
            get => _requireSecureTransport;
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
                _requireSecureTransport = value;
            }
        }

        private object? _skipNameResolve;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#skip_name_resolve MysqlMysqlConfiguration#skip_name_resolve}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipNameResolve", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SkipNameResolve
        {
            get => _skipNameResolve;
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
                _skipNameResolve = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#sort_buffer_size MysqlMysqlConfiguration#sort_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortBufferSize
        {
            get;
            set;
        }

        private object? _sqlGenerateInvisiblePrimaryKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#sql_generate_invisible_primary_key MysqlMysqlConfiguration#sql_generate_invisible_primary_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlGenerateInvisiblePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SqlGenerateInvisiblePrimaryKey
        {
            get => _sqlGenerateInvisiblePrimaryKey;
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
                _sqlGenerateInvisiblePrimaryKey = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#sql_mode MysqlMysqlConfiguration#sql_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqlMode
        {
            get;
            set;
        }

        private object? _sqlRequirePrimaryKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#sql_require_primary_key MysqlMysqlConfiguration#sql_require_primary_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlRequirePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SqlRequirePrimaryKey
        {
            get => _sqlRequirePrimaryKey;
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
                _sqlRequirePrimaryKey = value;
            }
        }

        private object? _sqlWarnings;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#sql_warnings MysqlMysqlConfiguration#sql_warnings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlWarnings", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SqlWarnings
        {
            get => _sqlWarnings;
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
                _sqlWarnings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#table_definition_cache MysqlMysqlConfiguration#table_definition_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableDefinitionCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TableDefinitionCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#table_open_cache MysqlMysqlConfiguration#table_open_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableOpenCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TableOpenCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#temptable_max_ram MysqlMysqlConfiguration#temptable_max_ram}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "temptableMaxRam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemptableMaxRam
        {
            get;
            set;
        }

        private object? _threadPoolDedicatedListeners;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#thread_pool_dedicated_listeners MysqlMysqlConfiguration#thread_pool_dedicated_listeners}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolDedicatedListeners", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ThreadPoolDedicatedListeners
        {
            get => _threadPoolDedicatedListeners;
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
                _threadPoolDedicatedListeners = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#thread_pool_max_transactions_limit MysqlMysqlConfiguration#thread_pool_max_transactions_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolMaxTransactionsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolMaxTransactionsLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#thread_pool_query_threads_per_group MysqlMysqlConfiguration#thread_pool_query_threads_per_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolQueryThreadsPerGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolQueryThreadsPerGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#thread_pool_size MysqlMysqlConfiguration#thread_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#thread_pool_transaction_delay MysqlMysqlConfiguration#thread_pool_transaction_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolTransactionDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolTransactionDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#time_zone MysqlMysqlConfiguration#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#tmp_table_size MysqlMysqlConfiguration#tmp_table_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TmpTableSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#transaction_isolation MysqlMysqlConfiguration#transaction_isolation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transactionIsolation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransactionIsolation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#wait_timeout MysqlMysqlConfiguration#wait_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimeout
        {
            get;
            set;
        }
    }
}
