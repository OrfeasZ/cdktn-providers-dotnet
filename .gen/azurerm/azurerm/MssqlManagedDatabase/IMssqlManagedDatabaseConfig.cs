using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlManagedDatabaseConfig), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseConfig")]
    public interface IMssqlManagedDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#managed_instance_id MssqlManagedDatabase#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#name MssqlManagedDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#id MssqlManagedDatabase#id}.</summary>
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

        /// <summary>long_term_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#long_term_retention_policy MssqlManagedDatabase#long_term_retention_policy}
        /// </remarks>
        [JsiiProperty(name: "longTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy? LongTermRetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>point_in_time_restore block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#point_in_time_restore MssqlManagedDatabase#point_in_time_restore}
        /// </remarks>
        [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlManagedDatabase.IMssqlManagedDatabasePointInTimeRestore? PointInTimeRestore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#short_term_retention_days MssqlManagedDatabase#short_term_retention_days}.</summary>
        [JsiiProperty(name: "shortTermRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShortTermRetentionDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#tags MssqlManagedDatabase#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#timeouts MssqlManagedDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlManagedDatabaseConfig), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#managed_instance_id MssqlManagedDatabase#managed_instance_id}.</summary>
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#name MssqlManagedDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#id MssqlManagedDatabase#id}.</summary>
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

            /// <summary>long_term_retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#long_term_retention_policy MssqlManagedDatabase#long_term_retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy\"}", isOptional: true)]
            public azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy? LongTermRetentionPolicy
            {
                get => GetInstanceProperty<azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy?>();
            }

            /// <summary>point_in_time_restore block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#point_in_time_restore MssqlManagedDatabase#point_in_time_restore}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeRestore", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore\"}", isOptional: true)]
            public azurerm.MssqlManagedDatabase.IMssqlManagedDatabasePointInTimeRestore? PointInTimeRestore
            {
                get => GetInstanceProperty<azurerm.MssqlManagedDatabase.IMssqlManagedDatabasePointInTimeRestore?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#short_term_retention_days MssqlManagedDatabase#short_term_retention_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shortTermRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShortTermRetentionDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#tags MssqlManagedDatabase#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_database#timeouts MssqlManagedDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabaseTimeouts\"}", isOptional: true)]
            public azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseTimeouts?>();
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
