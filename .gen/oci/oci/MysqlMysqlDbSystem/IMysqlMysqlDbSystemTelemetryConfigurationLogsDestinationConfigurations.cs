using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations")]
    public interface IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#key MysqlMysqlDbSystem#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#value MysqlMysqlDbSystem#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogsDestinationConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#key MysqlMysqlDbSystem#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_mysql_db_system#value MysqlMysqlDbSystem#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
