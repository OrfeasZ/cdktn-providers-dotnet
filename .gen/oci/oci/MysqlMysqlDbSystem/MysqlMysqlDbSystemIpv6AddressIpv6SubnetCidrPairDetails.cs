using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails")]
    public class MysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#ipv6address MysqlMysqlDbSystem#ipv6address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_db_system#ipv6subnet_cidr MysqlMysqlDbSystem#ipv6subnet_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6SubnetCidr
        {
            get;
            set;
        }
    }
}
