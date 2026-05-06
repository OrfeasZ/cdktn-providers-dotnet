using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    [JsiiInterface(nativeType: typeof(IMysqlChannelSourceAnonymousTransactionsHandling), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling")]
    public interface IMysqlChannelSourceAnonymousTransactionsHandling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#policy MysqlChannel#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        string Policy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_filename MysqlChannel#last_configured_log_filename}.</summary>
        [JsiiProperty(name: "lastConfiguredLogFilename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastConfiguredLogFilename
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_offset MysqlChannel#last_configured_log_offset}.</summary>
        [JsiiProperty(name: "lastConfiguredLogOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastConfiguredLogOffset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#uuid MysqlChannel#uuid}.</summary>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlChannelSourceAnonymousTransactionsHandling), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#policy MysqlChannel#policy}.</summary>
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
            public string Policy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_filename MysqlChannel#last_configured_log_filename}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastConfiguredLogFilename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastConfiguredLogFilename
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#last_configured_log_offset MysqlChannel#last_configured_log_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastConfiguredLogOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastConfiguredLogOffset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#uuid MysqlChannel#uuid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
