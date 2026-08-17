using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.DefaultPrivileges
{
    [JsiiInterface(nativeType: typeof(IDefaultPrivilegesConfig), fullyQualifiedName: "postgresql.defaultPrivileges.DefaultPrivilegesConfig")]
    public interface IDefaultPrivilegesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The database to grant default privileges for this role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#database DefaultPrivileges#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>The PostgreSQL object type to set the default privileges on (one of: table, sequence, function, routine, type, schema).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#object_type DefaultPrivileges#object_type}
        /// </remarks>
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectType
        {
            get;
        }

        /// <summary>Target role for which to alter default privileges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#owner DefaultPrivileges#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        /// <summary>The list of privileges to apply as default privileges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#privileges DefaultPrivileges#privileges}
        /// </remarks>
        [JsiiProperty(name: "privileges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Privileges
        {
            get;
        }

        /// <summary>The name of the role to which grant default privileges on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#role DefaultPrivileges#role}
        /// </remarks>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#id DefaultPrivileges#id}.</summary>
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

        /// <summary>The database schema to set default privileges for this role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#schema DefaultPrivileges#schema}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#with_grant_option DefaultPrivileges#with_grant_option}
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

        [JsiiTypeProxy(nativeType: typeof(IDefaultPrivilegesConfig), fullyQualifiedName: "postgresql.defaultPrivileges.DefaultPrivilegesConfig")]
        internal sealed class _Proxy : DeputyBase, postgresql.DefaultPrivileges.IDefaultPrivilegesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The database to grant default privileges for this role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#database DefaultPrivileges#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The PostgreSQL object type to set the default privileges on (one of: table, sequence, function, routine, type, schema).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#object_type DefaultPrivileges#object_type}
            /// </remarks>
            [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Target role for which to alter default privileges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#owner DefaultPrivileges#owner}
            /// </remarks>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of privileges to apply as default privileges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#privileges DefaultPrivileges#privileges}
            /// </remarks>
            [JsiiProperty(name: "privileges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Privileges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The name of the role to which grant default privileges on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#role DefaultPrivileges#role}
            /// </remarks>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#id DefaultPrivileges#id}.</summary>
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

            /// <summary>The database schema to set default privileges for this role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#schema DefaultPrivileges#schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Permit the grant recipient to grant it to others.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs/resources/default_privileges#with_grant_option DefaultPrivileges#with_grant_option}
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
