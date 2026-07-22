using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemReadEndpoint), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpoint")]
    public interface IMysqlMysqlDbSystemReadEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#exclude_ips MysqlMysqlDbSystem#exclude_ips}.</summary>
        [JsiiProperty(name: "excludeIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludeIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_hostname_label MysqlMysqlDbSystem#read_endpoint_hostname_label}.</summary>
        [JsiiProperty(name: "readEndpointHostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReadEndpointHostnameLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_ip_address MysqlMysqlDbSystem#read_endpoint_ip_address}.</summary>
        [JsiiProperty(name: "readEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReadEndpointIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>read_endpoint_ipv6address_ipv6subnet_cidr_pair_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details MysqlMysqlDbSystem#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details}
        /// </remarks>
        [JsiiProperty(name: "readEndpointIpv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails? ReadEndpointIpv6AddressIpv6SubnetCidrPairDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemReadEndpoint), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpoint")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#exclude_ips MysqlMysqlDbSystem#exclude_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludeIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_hostname_label MysqlMysqlDbSystem#read_endpoint_hostname_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readEndpointHostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReadEndpointHostnameLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_ip_address MysqlMysqlDbSystem#read_endpoint_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReadEndpointIpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>read_endpoint_ipv6address_ipv6subnet_cidr_pair_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details MysqlMysqlDbSystem#read_endpoint_ipv6address_ipv6subnet_cidr_pair_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readEndpointIpv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails\"}", isOptional: true)]
            public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails? ReadEndpointIpv6AddressIpv6SubnetCidrPairDetails
            {
                get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails?>();
            }
        }
    }
}
