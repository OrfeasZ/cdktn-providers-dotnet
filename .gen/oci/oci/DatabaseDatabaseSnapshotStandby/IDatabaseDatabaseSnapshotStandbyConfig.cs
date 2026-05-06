using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseSnapshotStandby
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseSnapshotStandbyConfig), fullyQualifiedName: "oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConfig")]
    public interface IDatabaseDatabaseSnapshotStandbyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#database_admin_password DatabaseDatabaseSnapshotStandby#database_admin_password}.</summary>
        [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseAdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#database_id DatabaseDatabaseSnapshotStandby#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#standby_conversion_type DatabaseDatabaseSnapshotStandby#standby_conversion_type}.</summary>
        [JsiiProperty(name: "standbyConversionType", typeJson: "{\"primitive\":\"string\"}")]
        string StandbyConversionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#id DatabaseDatabaseSnapshotStandby#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#snapshot_duration_in_days DatabaseDatabaseSnapshotStandby#snapshot_duration_in_days}.</summary>
        [JsiiProperty(name: "snapshotDurationInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SnapshotDurationInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#timeouts DatabaseDatabaseSnapshotStandby#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseSnapshotStandbyConfig), fullyQualifiedName: "oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#database_admin_password DatabaseDatabaseSnapshotStandby#database_admin_password}.</summary>
            [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#database_id DatabaseDatabaseSnapshotStandby#database_id}.</summary>
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#standby_conversion_type DatabaseDatabaseSnapshotStandby#standby_conversion_type}.</summary>
            [JsiiProperty(name: "standbyConversionType", typeJson: "{\"primitive\":\"string\"}")]
            public string StandbyConversionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#id DatabaseDatabaseSnapshotStandby#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#snapshot_duration_in_days DatabaseDatabaseSnapshotStandby#snapshot_duration_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotDurationInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SnapshotDurationInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_snapshot_standby#timeouts DatabaseDatabaseSnapshotStandby#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseDatabaseSnapshotStandby.DatabaseDatabaseSnapshotStandbyTimeouts\"}", isOptional: true)]
            public oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseDatabaseSnapshotStandby.IDatabaseDatabaseSnapshotStandbyTimeouts?>();
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
