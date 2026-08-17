using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.Grant
{
    [JsiiInterface(nativeType: typeof(IGrantConfig), fullyQualifiedName: "postgresql.grant.GrantConfig")]
    public interface IGrantConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The database to grant privileges on for this role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#database Grant#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>The PostgreSQL object type to grant the privileges on (one of: database, function, procedure, routine, schema, sequence, table, foreign_data_wrapper, foreign_server, column).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#object_type Grant#object_type}
        /// </remarks>
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectType
        {
            get;
        }

        /// <summary>The list of privileges to grant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#privileges Grant#privileges}
        /// </remarks>
        [JsiiProperty(name: "privileges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Privileges
        {
            get;
        }

        /// <summary>The name of the role to grant privileges on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#role Grant#role}
        /// </remarks>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>The specific columns to grant privileges on for this role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#columns Grant#columns}
        /// </remarks>
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Columns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#id Grant#id}.</summary>
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

        /// <summary>The specific objects to grant privileges on for this role (empty means all objects of the requested type).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#objects Grant#objects}
        /// </remarks>
        [JsiiProperty(name: "objects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Objects
        {
            get
            {
                return null;
            }
        }

        /// <summary>The database schema to grant privileges on for this role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#schema Grant#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Permit the grant recipient to grant it to others.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#with_grant_option Grant#with_grant_option}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "withGrantOption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WithGrantOption
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGrantConfig), fullyQualifiedName: "postgresql.grant.GrantConfig")]
        internal sealed class _Proxy : DeputyBase, postgresql.Grant.IGrantConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The database to grant privileges on for this role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#database Grant#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The PostgreSQL object type to grant the privileges on (one of: database, function, procedure, routine, schema, sequence, table, foreign_data_wrapper, foreign_server, column).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#object_type Grant#object_type}
            /// </remarks>
            [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of privileges to grant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#privileges Grant#privileges}
            /// </remarks>
            [JsiiProperty(name: "privileges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Privileges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The name of the role to grant privileges on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#role Grant#role}
            /// </remarks>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The specific columns to grant privileges on for this role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#columns Grant#columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Columns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#id Grant#id}.</summary>
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

            /// <summary>The specific objects to grant privileges on for this role (empty means all objects of the requested type).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#objects Grant#objects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Objects
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The database schema to grant privileges on for this role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#schema Grant#schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Permit the grant recipient to grant it to others.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/grant#with_grant_option Grant#with_grant_option}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withGrantOption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WithGrantOption
            {
                get => GetInstanceProperty<object?>();
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
