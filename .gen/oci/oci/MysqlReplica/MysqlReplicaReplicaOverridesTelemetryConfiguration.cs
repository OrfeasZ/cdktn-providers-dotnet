using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiByValue(fqn: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfiguration")]
    public class MysqlReplicaReplicaOverridesTelemetryConfiguration : oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfiguration
    {
        private object? _logs;

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_replica#logs MysqlReplica#logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Logs
        {
            get => _logs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logs = value;
            }
        }
    }
}
