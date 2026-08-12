using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemSourceChannel), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannel")]
    public interface IMysqlMysqlDbSystemSourceChannel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#applier_username MysqlMysqlDbSystem#applier_username}.</summary>
        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplierUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#source_password MysqlMysqlDbSystem#source_password}.</summary>
        [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourcePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#source_username MysqlMysqlDbSystem#source_username}.</summary>
        [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_ca_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#ssl_ca_certificate MysqlMysqlDbSystem#ssl_ca_certificate}
        /// </remarks>
        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate? SslCaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#ssl_mode MysqlMysqlDbSystem#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemSourceChannel), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannel")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#applier_username MysqlMysqlDbSystem#applier_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplierUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#source_password MysqlMysqlDbSystem#source_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourcePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#source_username MysqlMysqlDbSystem#source_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ssl_ca_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#ssl_ca_certificate MysqlMysqlDbSystem#ssl_ca_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemSourceChannelSslCaCertificate\"}", isOptional: true)]
            public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate? SslCaCertificate
            {
                get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemSourceChannelSslCaCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/mysql_mysql_db_system#ssl_mode MysqlMysqlDbSystem#ssl_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
