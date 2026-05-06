using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling")]
    public class MysqlChannelSourceAnonymousTransactionsHandling : oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#policy MysqlChannel#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public string Policy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_filename MysqlChannel#last_configured_log_filename}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastConfiguredLogFilename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastConfiguredLogFilename
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_offset MysqlChannel#last_configured_log_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastConfiguredLogOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastConfiguredLogOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#uuid MysqlChannel#uuid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
