using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails")]
    public interface IMysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/mysql_mysql_db_system#ipv6address MysqlMysqlDbSystem#ipv6address}.</summary>
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/mysql_mysql_db_system#ipv6subnet_cidr MysqlMysqlDbSystem#ipv6subnet_cidr}.</summary>
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6SubnetCidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/mysql_mysql_db_system#ipv6address MysqlMysqlDbSystem#ipv6address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/mysql_mysql_db_system#ipv6subnet_cidr MysqlMysqlDbSystem#ipv6subnet_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6SubnetCidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
