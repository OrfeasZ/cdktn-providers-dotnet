using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemTelemetryConfigurationLogs), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogs")]
    public interface IMysqlMysqlDbSystemTelemetryConfigurationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#destination MysqlMysqlDbSystem#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>destination_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#destination_configurations MysqlMysqlDbSystem#destination_configurations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations\"},\"kind\":\"array\"}}]}}")]
        object DestinationConfigurations
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#log_types MysqlMysqlDbSystem#log_types}.</summary>
        [JsiiProperty(name: "logTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LogTypes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemTelemetryConfigurationLogs), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogs")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#destination MysqlMysqlDbSystem#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#destination_configurations MysqlMysqlDbSystem#destination_configurations}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations\"},\"kind\":\"array\"}}]}}")]
            public object DestinationConfigurations
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#log_types MysqlMysqlDbSystem#log_types}.</summary>
            [JsiiProperty(name: "logTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LogTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
