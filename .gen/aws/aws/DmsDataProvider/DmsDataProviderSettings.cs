using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsDataProvider
{
    [JsiiByValue(fqn: "aws.dmsDataProvider.DmsDataProviderSettings")]
    public class DmsDataProviderSettings : aws.DmsDataProvider.IDmsDataProviderSettings
    {
        private object? _docDbSettings;

        /// <summary>doc_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#doc_db_settings DmsDataProvider#doc_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "docDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DocDbSettings
        {
            get => _docDbSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _docDbSettings = value;
            }
        }

        private object? _ibmDb2LuwSettings;

        /// <summary>ibm_db2_luw_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_luw_settings DmsDataProvider#ibm_db2_luw_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ibmDb2LuwSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IbmDb2LuwSettings
        {
            get => _ibmDb2LuwSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ibmDb2LuwSettings = value;
            }
        }

        private object? _ibmDb2ZosSettings;

        /// <summary>ibm_db2_zos_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_zos_settings DmsDataProvider#ibm_db2_zos_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ibmDb2ZosSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IbmDb2ZosSettings
        {
            get => _ibmDb2ZosSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ibmDb2ZosSettings = value;
            }
        }

        private object? _mariaDbSettings;

        /// <summary>maria_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#maria_db_settings DmsDataProvider#maria_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mariaDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MariaDbSettings
        {
            get => _mariaDbSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mariaDbSettings = value;
            }
        }

        private object? _microsoftSqlServerSettings;

        /// <summary>microsoft_sql_server_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#microsoft_sql_server_settings DmsDataProvider#microsoft_sql_server_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftSqlServerSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MicrosoftSqlServerSettings
        {
            get => _microsoftSqlServerSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _microsoftSqlServerSettings = value;
            }
        }

        private object? _mongoDbSettings;

        /// <summary>mongo_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mongo_db_settings DmsDataProvider#mongo_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongoDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MongoDbSettings
        {
            get => _mongoDbSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mongoDbSettings = value;
            }
        }

        private object? _mysqlSettings;

        /// <summary>mysql_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mysql_settings DmsDataProvider#mysql_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MysqlSettings
        {
            get => _mysqlSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mysqlSettings = value;
            }
        }

        private object? _oracleSettings;

        /// <summary>oracle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#oracle_settings DmsDataProvider#oracle_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oracleSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OracleSettings
        {
            get => _oracleSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _oracleSettings = value;
            }
        }

        private object? _postgresqlSettings;

        /// <summary>postgresql_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#postgresql_settings DmsDataProvider#postgresql_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PostgresqlSettings
        {
            get => _postgresqlSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _postgresqlSettings = value;
            }
        }

        private object? _redshiftSettings;

        /// <summary>redshift_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#redshift_settings DmsDataProvider#redshift_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshiftSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedshiftSettings
        {
            get => _redshiftSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redshiftSettings = value;
            }
        }

        private object? _sybaseAseSettings;

        /// <summary>sybase_ase_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#sybase_ase_settings DmsDataProvider#sybase_ase_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sybaseAseSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SybaseAseSettings
        {
            get => _sybaseAseSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sybaseAseSettings = value;
            }
        }
    }
}
