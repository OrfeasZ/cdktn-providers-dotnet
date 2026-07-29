using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemMaintenance), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
    public interface IMysqlMysqlDbSystemMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string WindowStartTime
        {
            get;
        }

        /// <summary>maintenance_disabled_windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#maintenance_disabled_windows MysqlMysqlDbSystem#maintenance_disabled_windows}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "maintenanceDisabledWindows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaintenanceDisabledWindows
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#maintenance_schedule_type MysqlMysqlDbSystem#maintenance_schedule_type}.</summary>
        [JsiiProperty(name: "maintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceScheduleType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#version_preference MysqlMysqlDbSystem#version_preference}.</summary>
        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#version_track_preference MysqlMysqlDbSystem#version_track_preference}.</summary>
        [JsiiProperty(name: "versionTrackPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionTrackPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemMaintenance), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
            [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string WindowStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>maintenance_disabled_windows block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#maintenance_disabled_windows MysqlMysqlDbSystem#maintenance_disabled_windows}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceDisabledWindows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaintenanceDisabledWindows
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#maintenance_schedule_type MysqlMysqlDbSystem#maintenance_schedule_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceScheduleType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#version_preference MysqlMysqlDbSystem#version_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#version_track_preference MysqlMysqlDbSystem#version_track_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionTrackPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionTrackPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
