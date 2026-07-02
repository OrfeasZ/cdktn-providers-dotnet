using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfiguration")]
    public class MysqlMysqlDbSystemTelemetryConfiguration : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfiguration
    {
        private object? _logs;

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/mysql_mysql_db_system#logs MysqlMysqlDbSystem#logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemTelemetryConfigurationLogs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logs = value;
            }
        }
    }
}
