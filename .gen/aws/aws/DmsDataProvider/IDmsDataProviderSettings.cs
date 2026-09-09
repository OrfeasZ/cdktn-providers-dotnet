using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsDataProvider
{
    [JsiiInterface(nativeType: typeof(IDmsDataProviderSettings), fullyQualifiedName: "aws.dmsDataProvider.DmsDataProviderSettings")]
    public interface IDmsDataProviderSettings
    {
        /// <summary>doc_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#doc_db_settings DmsDataProvider#doc_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "docDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DocDbSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>ibm_db2_luw_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_luw_settings DmsDataProvider#ibm_db2_luw_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ibmDb2LuwSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IbmDb2LuwSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>ibm_db2_zos_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_zos_settings DmsDataProvider#ibm_db2_zos_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ibmDb2ZosSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IbmDb2ZosSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>maria_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#maria_db_settings DmsDataProvider#maria_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "mariaDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MariaDbSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft_sql_server_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#microsoft_sql_server_settings DmsDataProvider#microsoft_sql_server_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "microsoftSqlServerSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MicrosoftSqlServerSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongo_db_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mongo_db_settings DmsDataProvider#mongo_db_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "mongoDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MongoDbSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>mysql_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mysql_settings DmsDataProvider#mysql_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "mysqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MysqlSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>oracle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#oracle_settings DmsDataProvider#oracle_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "oracleSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OracleSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgresql_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#postgresql_settings DmsDataProvider#postgresql_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "postgresqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostgresqlSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#redshift_settings DmsDataProvider#redshift_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "redshiftSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedshiftSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>sybase_ase_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#sybase_ase_settings DmsDataProvider#sybase_ase_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sybaseAseSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SybaseAseSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsDataProviderSettings), fullyQualifiedName: "aws.dmsDataProvider.DmsDataProviderSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsDataProvider.IDmsDataProviderSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>doc_db_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#doc_db_settings DmsDataProvider#doc_db_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "docDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DocDbSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ibm_db2_luw_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_luw_settings DmsDataProvider#ibm_db2_luw_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ibmDb2LuwSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IbmDb2LuwSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ibm_db2_zos_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#ibm_db2_zos_settings DmsDataProvider#ibm_db2_zos_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ibmDb2ZosSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IbmDb2ZosSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>maria_db_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#maria_db_settings DmsDataProvider#maria_db_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mariaDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MariaDbSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>microsoft_sql_server_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#microsoft_sql_server_settings DmsDataProvider#microsoft_sql_server_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftSqlServerSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MicrosoftSqlServerSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>mongo_db_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mongo_db_settings DmsDataProvider#mongo_db_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongoDbSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MongoDbSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>mysql_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#mysql_settings DmsDataProvider#mysql_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mysqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MysqlSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>oracle_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#oracle_settings DmsDataProvider#oracle_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oracleSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OracleSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>postgresql_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#postgresql_settings DmsDataProvider#postgresql_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresqlSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostgresqlSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>redshift_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#redshift_settings DmsDataProvider#redshift_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedshiftSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sybase_ase_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/dms_data_provider#sybase_ase_settings DmsDataProvider#sybase_ase_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sybaseAseSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SybaseAseSettings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
