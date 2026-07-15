using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenance")]
    public class MysqlMysqlDbSystemMaintenance : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string WindowStartTime
        {
            get;
            set;
        }

        private object? _maintenanceDisabledWindows;

        /// <summary>maintenance_disabled_windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/mysql_mysql_db_system#maintenance_disabled_windows MysqlMysqlDbSystem#maintenance_disabled_windows}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceDisabledWindows", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceDisabledWindows
        {
            get => _maintenanceDisabledWindows;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemMaintenanceMaintenanceDisabledWindows).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceDisabledWindows = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/mysql_mysql_db_system#maintenance_schedule_type MysqlMysqlDbSystem#maintenance_schedule_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceScheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceScheduleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/mysql_mysql_db_system#version_preference MysqlMysqlDbSystem#version_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/mysql_mysql_db_system#version_track_preference MysqlMysqlDbSystem#version_track_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionTrackPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionTrackPreference
        {
            get;
            set;
        }
    }
}
