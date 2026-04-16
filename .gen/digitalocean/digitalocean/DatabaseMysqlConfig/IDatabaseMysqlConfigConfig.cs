using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseMysqlConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseMysqlConfigConfig), fullyQualifiedName: "digitalocean.databaseMysqlConfig.DatabaseMysqlConfigConfig")]
    public interface IDatabaseMysqlConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#cluster_id DatabaseMysqlConfig#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_hour DatabaseMysqlConfig#backup_hour}.</summary>
        [JsiiProperty(name: "backupHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_minute DatabaseMysqlConfig#backup_minute}.</summary>
        [JsiiProperty(name: "backupMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupMinute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#binlog_retention_period DatabaseMysqlConfig#binlog_retention_period}.</summary>
        [JsiiProperty(name: "binlogRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BinlogRetentionPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#connect_timeout DatabaseMysqlConfig#connect_timeout}.</summary>
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#default_time_zone DatabaseMysqlConfig#default_time_zone}.</summary>
        [JsiiProperty(name: "defaultTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultTimeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#group_concat_max_len DatabaseMysqlConfig#group_concat_max_len}.</summary>
        [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GroupConcatMaxLen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#id DatabaseMysqlConfig#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#information_schema_stats_expiry DatabaseMysqlConfig#information_schema_stats_expiry}.</summary>
        [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InformationSchemaStatsExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_min_token_size DatabaseMysqlConfig#innodb_ft_min_token_size}.</summary>
        [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InnodbFtMinTokenSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_server_stopword_table DatabaseMysqlConfig#innodb_ft_server_stopword_table}.</summary>
        [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InnodbFtServerStopwordTable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_lock_wait_timeout DatabaseMysqlConfig#innodb_lock_wait_timeout}.</summary>
        [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InnodbLockWaitTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_log_buffer_size DatabaseMysqlConfig#innodb_log_buffer_size}.</summary>
        [JsiiProperty(name: "innodbLogBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InnodbLogBufferSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_online_alter_log_max_size DatabaseMysqlConfig#innodb_online_alter_log_max_size}.</summary>
        [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InnodbOnlineAlterLogMaxSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_print_all_deadlocks DatabaseMysqlConfig#innodb_print_all_deadlocks}.</summary>
        [JsiiProperty(name: "innodbPrintAllDeadlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InnodbPrintAllDeadlocks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_rollback_on_timeout DatabaseMysqlConfig#innodb_rollback_on_timeout}.</summary>
        [JsiiProperty(name: "innodbRollbackOnTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InnodbRollbackOnTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#interactive_timeout DatabaseMysqlConfig#interactive_timeout}.</summary>
        [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InteractiveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#internal_tmp_mem_storage_engine DatabaseMysqlConfig#internal_tmp_mem_storage_engine}.</summary>
        [JsiiProperty(name: "internalTmpMemStorageEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InternalTmpMemStorageEngine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#long_query_time DatabaseMysqlConfig#long_query_time}.</summary>
        [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LongQueryTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_allowed_packet DatabaseMysqlConfig#max_allowed_packet}.</summary>
        [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAllowedPacket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_heap_table_size DatabaseMysqlConfig#max_heap_table_size}.</summary>
        [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxHeapTableSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_read_timeout DatabaseMysqlConfig#net_read_timeout}.</summary>
        [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NetReadTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_write_timeout DatabaseMysqlConfig#net_write_timeout}.</summary>
        [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NetWriteTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#slow_query_log DatabaseMysqlConfig#slow_query_log}.</summary>
        [JsiiProperty(name: "slowQueryLog", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SlowQueryLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sort_buffer_size DatabaseMysqlConfig#sort_buffer_size}.</summary>
        [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SortBufferSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_mode DatabaseMysqlConfig#sql_mode}.</summary>
        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_require_primary_key DatabaseMysqlConfig#sql_require_primary_key}.</summary>
        [JsiiProperty(name: "sqlRequirePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SqlRequirePrimaryKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#tmp_table_size DatabaseMysqlConfig#tmp_table_size}.</summary>
        [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TmpTableSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#wait_timeout DatabaseMysqlConfig#wait_timeout}.</summary>
        [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMysqlConfigConfig), fullyQualifiedName: "digitalocean.databaseMysqlConfig.DatabaseMysqlConfigConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseMysqlConfig.IDatabaseMysqlConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#cluster_id DatabaseMysqlConfig#cluster_id}.</summary>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_hour DatabaseMysqlConfig#backup_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#backup_minute DatabaseMysqlConfig#backup_minute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupMinute
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#binlog_retention_period DatabaseMysqlConfig#binlog_retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "binlogRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BinlogRetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#connect_timeout DatabaseMysqlConfig#connect_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#default_time_zone DatabaseMysqlConfig#default_time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultTimeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#group_concat_max_len DatabaseMysqlConfig#group_concat_max_len}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupConcatMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GroupConcatMaxLen
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#information_schema_stats_expiry DatabaseMysqlConfig#information_schema_stats_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "informationSchemaStatsExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InformationSchemaStatsExpiry
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_min_token_size DatabaseMysqlConfig#innodb_ft_min_token_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbFtMinTokenSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InnodbFtMinTokenSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_ft_server_stopword_table DatabaseMysqlConfig#innodb_ft_server_stopword_table}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbFtServerStopwordTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InnodbFtServerStopwordTable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_lock_wait_timeout DatabaseMysqlConfig#innodb_lock_wait_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbLockWaitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InnodbLockWaitTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_log_buffer_size DatabaseMysqlConfig#innodb_log_buffer_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbLogBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InnodbLogBufferSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_online_alter_log_max_size DatabaseMysqlConfig#innodb_online_alter_log_max_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbOnlineAlterLogMaxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InnodbOnlineAlterLogMaxSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_print_all_deadlocks DatabaseMysqlConfig#innodb_print_all_deadlocks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbPrintAllDeadlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InnodbPrintAllDeadlocks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#innodb_rollback_on_timeout DatabaseMysqlConfig#innodb_rollback_on_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "innodbRollbackOnTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InnodbRollbackOnTimeout
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#interactive_timeout DatabaseMysqlConfig#interactive_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interactiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InteractiveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#internal_tmp_mem_storage_engine DatabaseMysqlConfig#internal_tmp_mem_storage_engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalTmpMemStorageEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InternalTmpMemStorageEngine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#long_query_time DatabaseMysqlConfig#long_query_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "longQueryTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LongQueryTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_allowed_packet DatabaseMysqlConfig#max_allowed_packet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAllowedPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAllowedPacket
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#max_heap_table_size DatabaseMysqlConfig#max_heap_table_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxHeapTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxHeapTableSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_read_timeout DatabaseMysqlConfig#net_read_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NetReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#net_write_timeout DatabaseMysqlConfig#net_write_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netWriteTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NetWriteTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#slow_query_log DatabaseMysqlConfig#slow_query_log}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slowQueryLog", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SlowQueryLog
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sort_buffer_size DatabaseMysqlConfig#sort_buffer_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sortBufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SortBufferSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_mode DatabaseMysqlConfig#sql_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#sql_require_primary_key DatabaseMysqlConfig#sql_require_primary_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlRequirePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SqlRequirePrimaryKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#tmp_table_size DatabaseMysqlConfig#tmp_table_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tmpTableSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TmpTableSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_mysql_config#wait_timeout DatabaseMysqlConfig#wait_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
