using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.DataPostgresqlTables
{
    [JsiiInterface(nativeType: typeof(IDataPostgresqlTablesConfig), fullyQualifiedName: "postgresql.dataPostgresqlTables.DataPostgresqlTablesConfig")]
    public interface IDataPostgresqlTablesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The PostgreSQL database which will be queried for table names.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#database DataPostgresqlTables#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#id DataPostgresqlTables#id}.</summary>
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

        /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL LIKE ALL operator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#like_all_patterns DataPostgresqlTables#like_all_patterns}
        /// </remarks>
        [JsiiProperty(name: "likeAllPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LikeAllPatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL LIKE ANY operator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#like_any_patterns DataPostgresqlTables#like_any_patterns}
        /// </remarks>
        [JsiiProperty(name: "likeAnyPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LikeAnyPatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL NOT LIKE ALL operator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#not_like_all_patterns DataPostgresqlTables#not_like_all_patterns}
        /// </remarks>
        [JsiiProperty(name: "notLikeAllPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotLikeAllPatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Expression which will be pattern matched against table names in the query using the PostgreSQL ~ (regular expression match) operator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#regex_pattern DataPostgresqlTables#regex_pattern}
        /// </remarks>
        [JsiiProperty(name: "regexPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegexPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PostgreSQL schema(s) which will be queried for table names. Queries all schemas in the database by default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#schemas DataPostgresqlTables#schemas}
        /// </remarks>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Schemas
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PostgreSQL table types which will be queried for table names.</summary>
        /// <remarks>
        /// Includes all table types by default. Use 'BASE TABLE' for normal tables only
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#table_types DataPostgresqlTables#table_types}
        /// </remarks>
        [JsiiProperty(name: "tableTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TableTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataPostgresqlTablesConfig), fullyQualifiedName: "postgresql.dataPostgresqlTables.DataPostgresqlTablesConfig")]
        internal sealed class _Proxy : DeputyBase, postgresql.DataPostgresqlTables.IDataPostgresqlTablesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The PostgreSQL database which will be queried for table names.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#database DataPostgresqlTables#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#id DataPostgresqlTables#id}.</summary>
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

            /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL LIKE ALL operator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#like_all_patterns DataPostgresqlTables#like_all_patterns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "likeAllPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LikeAllPatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL LIKE ANY operator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#like_any_patterns DataPostgresqlTables#like_any_patterns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "likeAnyPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LikeAnyPatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Expression(s) which will be pattern matched against table names in the query using the PostgreSQL NOT LIKE ALL operator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#not_like_all_patterns DataPostgresqlTables#not_like_all_patterns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notLikeAllPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotLikeAllPatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Expression which will be pattern matched against table names in the query using the PostgreSQL ~ (regular expression match) operator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#regex_pattern DataPostgresqlTables#regex_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegexPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The PostgreSQL schema(s) which will be queried for table names. Queries all schemas in the database by default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#schemas DataPostgresqlTables#schemas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Schemas
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The PostgreSQL table types which will be queried for table names.</summary>
            /// <remarks>
            /// Includes all table types by default. Use 'BASE TABLE' for normal tables only
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/data-sources/tables#table_types DataPostgresqlTables#table_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TableTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
