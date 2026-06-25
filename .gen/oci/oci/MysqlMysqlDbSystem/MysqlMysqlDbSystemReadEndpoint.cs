using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpoint")]
    public class MysqlMysqlDbSystemReadEndpoint : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/mysql_mysql_db_system#exclude_ips MysqlMysqlDbSystem#exclude_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeIps
        {
            get;
            set;
        }

        private object? _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnabled
        {
            get => _isEnabled;
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
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/mysql_mysql_db_system#read_endpoint_hostname_label MysqlMysqlDbSystem#read_endpoint_hostname_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readEndpointHostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReadEndpointHostnameLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/mysql_mysql_db_system#read_endpoint_ip_address MysqlMysqlDbSystem#read_endpoint_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReadEndpointIpAddress
        {
            get;
            set;
        }

        /// <summary>read_endpoint_ipv6address_ipv6subnet_cidr_pair_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/mysql_mysql_db_system#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details MysqlMysqlDbSystem#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readEndpointIpv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails\"}", isOptional: true)]
        public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails? ReadEndpointIpv6AddressIpv6SubnetCidrPairDetails
        {
            get;
            set;
        }
    }
}
