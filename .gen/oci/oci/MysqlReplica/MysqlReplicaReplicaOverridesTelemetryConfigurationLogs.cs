using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs")]
    public class MysqlReplicaReplicaOverridesTelemetryConfigurationLogs : oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_replica#destination MysqlReplica#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        private object _destinationConfigurations;

        /// <summary>destination_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_replica#destination_configurations MysqlReplica#destination_configurations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destinationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations\"},\"kind\":\"array\"}}]}}")]
        public object DestinationConfigurations
        {
            get => _destinationConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destinationConfigurations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_replica#log_types MysqlReplica#log_types}.</summary>
        [JsiiProperty(name: "logTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LogTypes
        {
            get;
            set;
        }
    }
}
