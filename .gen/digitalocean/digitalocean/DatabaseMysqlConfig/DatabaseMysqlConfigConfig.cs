using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseMysqlConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseMysqlConfig.DatabaseMysqlConfigConfig")]
    public class DatabaseMysqlConfigConfig : digitalocean.DatabaseMysqlConfig.IDatabaseMysqlConfigConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#cluster_id DatabaseMysqlConfig#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_hour DatabaseMysqlConfig#backup_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_minute DatabaseMysqlConfig#backup_minute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupMinute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#binlog_retention_period DatabaseMysqlConfig#binlog_retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "binlogRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BinlogRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#connect_timeout DatabaseMysqlConfig#connect_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#default_time_zone DatabaseMysqlConfig#default_time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultTimeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#group_concat_max_len DatabaseMysqlConfig#group_concat_max_len}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupConcatMaxLen
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#id DatabaseMysqlConfig#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#information_schema_stats_expiry DatabaseMysqlConfig#information_schema_stats_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InformationSchemaStatsExpiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_min_token_size DatabaseMysqlConfig#innodb_ft_min_token_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbFtMinTokenSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_server_stopword_table DatabaseMysqlConfig#innodb_ft_server_stopword_table}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InnodbFtServerStopwordTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_lock_wait_timeout DatabaseMysqlConfig#innodb_lock_wait_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbLockWaitTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_log_buffer_size DatabaseMysqlConfig#innodb_log_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbLogBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbLogBufferSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_online_alter_log_max_size DatabaseMysqlConfig#innodb_online_alter_log_max_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InnodbOnlineAlterLogMaxSize
        {
            get;
            set;
        }

        private object? _innodbPrintAllDeadlocks;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_print_all_deadlocks DatabaseMysqlConfig#innodb_print_all_deadlocks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "innodbPrintAllDeadlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InnodbPrintAllDeadlocks
        {
            get => _innodbPrintAllDeadlocks;
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
                _innodbPrintAllDeadlocks = value;
            }
        }

        private object? _innodbRollbackOnTimeout;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_rollback_on_timeout DatabaseMysqlConfig#innodb_rollback_on_timeout}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#interactive_timeout DatabaseMysqlConfig#interactive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InteractiveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#internal_tmp_mem_storage_engine DatabaseMysqlConfig#internal_tmp_mem_storage_engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "internalTmpMemStorageEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InternalTmpMemStorageEngine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#long_query_time DatabaseMysqlConfig#long_query_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongQueryTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_allowed_packet DatabaseMysqlConfig#max_allowed_packet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllowedPacket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_heap_table_size DatabaseMysqlConfig#max_heap_table_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxHeapTableSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_read_timeout DatabaseMysqlConfig#net_read_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetReadTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_write_timeout DatabaseMysqlConfig#net_write_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetWriteTimeout
        {
            get;
            set;
        }

        private object? _slowQueryLog;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#slow_query_log DatabaseMysqlConfig#slow_query_log}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slowQueryLog", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SlowQueryLog
        {
            get => _slowQueryLog;
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
                _slowQueryLog = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sort_buffer_size DatabaseMysqlConfig#sort_buffer_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SortBufferSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_mode DatabaseMysqlConfig#sql_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqlMode
        {
            get;
            set;
        }

        private object? _sqlRequirePrimaryKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_require_primary_key DatabaseMysqlConfig#sql_require_primary_key}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#tmp_table_size DatabaseMysqlConfig#tmp_table_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TmpTableSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#wait_timeout DatabaseMysqlConfig#wait_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimeout
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
