using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlChannel.MysqlChannelSourceSslCaCertificate")]
    public class MysqlChannelSourceSslCaCertificate : oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#certificate_type MysqlChannel#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#contents MysqlChannel#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        public string Contents
        {
            get;
            set;
        }
    }
}
