using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlChannel.MysqlChannelTarget")]
    public class MysqlChannelTarget : oci.MysqlChannel.IMysqlChannelTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#db_system_id MysqlChannel#db_system_id}.</summary>
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string DbSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#target_type MysqlChannel#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#applier_username MysqlChannel#applier_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplierUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#channel_name MysqlChannel#channel_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChannelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#delay_in_seconds MysqlChannel#delay_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DelayInSeconds
        {
            get;
            set;
        }

        private object? _filters;

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#filters MysqlChannel#filters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlChannel.MysqlChannelTargetFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filters
        {
            get => _filters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MysqlChannel.IMysqlChannelTargetFilters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlChannel.IMysqlChannelTargetFilters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#tables_without_primary_key_handling MysqlChannel#tables_without_primary_key_handling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tablesWithoutPrimaryKeyHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TablesWithoutPrimaryKeyHandling
        {
            get;
            set;
        }
    }
}
