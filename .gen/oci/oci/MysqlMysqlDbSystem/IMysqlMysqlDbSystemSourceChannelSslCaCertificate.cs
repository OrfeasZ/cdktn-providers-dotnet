using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemSourceChannelSslCaCertificate), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate")]
    public interface IMysqlMysqlDbSystemSourceChannelSslCaCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#certificate_type MysqlMysqlDbSystem#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#contents MysqlMysqlDbSystem#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        string Contents
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemSourceChannelSslCaCertificate), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#certificate_type MysqlMysqlDbSystem#certificate_type}.</summary>
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/mysql_mysql_db_system#contents MysqlMysqlDbSystem#contents}.</summary>
            [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
            public string Contents
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
