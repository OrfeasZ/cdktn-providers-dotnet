using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlDbSystemMaintenanceEvents
{
    [JsiiInterface(nativeType: typeof(IDataOciMysqlDbSystemMaintenanceEventsConfig), fullyQualifiedName: "oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsConfig")]
    public interface IDataOciMysqlDbSystemMaintenanceEventsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#db_system_id DataOciMysqlDbSystemMaintenanceEvents#db_system_id}.</summary>
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string DbSystemId
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#filter DataOciMysqlDbSystemMaintenanceEvents#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#id DataOciMysqlDbSystemMaintenanceEvents#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_action DataOciMysqlDbSystemMaintenanceEvents#maintenance_action}.</summary>
        [JsiiProperty(name: "maintenanceAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_status DataOciMysqlDbSystemMaintenanceEvents#maintenance_status}.</summary>
        [JsiiProperty(name: "maintenanceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_type DataOciMysqlDbSystemMaintenanceEvents#maintenance_type}.</summary>
        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#mysql_version_after_maintenance DataOciMysqlDbSystemMaintenanceEvents#mysql_version_after_maintenance}.</summary>
        [JsiiProperty(name: "mysqlVersionAfterMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MysqlVersionAfterMaintenance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#mysql_version_before_maintenance DataOciMysqlDbSystemMaintenanceEvents#mysql_version_before_maintenance}.</summary>
        [JsiiProperty(name: "mysqlVersionBeforeMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MysqlVersionBeforeMaintenance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciMysqlDbSystemMaintenanceEventsConfig), fullyQualifiedName: "oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#db_system_id DataOciMysqlDbSystemMaintenanceEvents#db_system_id}.</summary>
            [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string DbSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#filter DataOciMysqlDbSystemMaintenanceEvents#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#id DataOciMysqlDbSystemMaintenanceEvents#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_action DataOciMysqlDbSystemMaintenanceEvents#maintenance_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_status DataOciMysqlDbSystemMaintenanceEvents#maintenance_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#maintenance_type DataOciMysqlDbSystemMaintenanceEvents#maintenance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#mysql_version_after_maintenance DataOciMysqlDbSystemMaintenanceEvents#mysql_version_after_maintenance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mysqlVersionAfterMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MysqlVersionAfterMaintenance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/mysql_db_system_maintenance_events#mysql_version_before_maintenance DataOciMysqlDbSystemMaintenanceEvents#mysql_version_before_maintenance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mysqlVersionBeforeMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MysqlVersionBeforeMaintenance
            {
                get => GetInstanceProperty<string?>();
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
