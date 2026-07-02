using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiInterface(nativeType: typeof(IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations")]
    public interface IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_replica#key MysqlReplica#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_replica#value MysqlReplica#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_replica#key MysqlReplica#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_replica#value MysqlReplica#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
