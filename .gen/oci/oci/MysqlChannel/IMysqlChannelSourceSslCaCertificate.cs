using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    [JsiiInterface(nativeType: typeof(IMysqlChannelSourceSslCaCertificate), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceSslCaCertificate")]
    public interface IMysqlChannelSourceSslCaCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#certificate_type MysqlChannel#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#contents MysqlChannel#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        string Contents
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlChannelSourceSslCaCertificate), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceSslCaCertificate")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlChannel.IMysqlChannelSourceSslCaCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#certificate_type MysqlChannel#certificate_type}.</summary>
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_channel#contents MysqlChannel#contents}.</summary>
            [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
            public string Contents
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
