using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlChannel.MysqlChannelSource")]
    public class MysqlChannelSource : oci.MysqlChannel.IMysqlChannelSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#hostname MysqlChannel#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#password MysqlChannel#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#source_type MysqlChannel#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#ssl_mode MysqlChannel#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public string SslMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#username MysqlChannel#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>anonymous_transactions_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#anonymous_transactions_handling MysqlChannel#anonymous_transactions_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anonymousTransactionsHandling", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling\"}", isOptional: true)]
        public oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling? AnonymousTransactionsHandling
        {
            get;
            set;
        }

        private object? _mustUseIpv6OnDualStack;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#must_use_ipv6on_dual_stack MysqlChannel#must_use_ipv6on_dual_stack}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mustUseIpv6OnDualStack", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MustUseIpv6OnDualStack
        {
            get => _mustUseIpv6OnDualStack;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mustUseIpv6OnDualStack = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#port MysqlChannel#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>ssl_ca_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_channel#ssl_ca_certificate MysqlChannel#ssl_ca_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceSslCaCertificate\"}", isOptional: true)]
        public oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate? SslCaCertificate
        {
            get;
            set;
        }
    }
}
