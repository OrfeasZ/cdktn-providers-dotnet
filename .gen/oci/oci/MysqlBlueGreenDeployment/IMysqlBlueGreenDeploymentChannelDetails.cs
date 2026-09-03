using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiInterface(nativeType: typeof(IMysqlBlueGreenDeploymentChannelDetails), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails")]
    public interface IMysqlBlueGreenDeploymentChannelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_password MysqlBlueGreenDeployment#source_password}.</summary>
        [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}")]
        string SourcePassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_username MysqlBlueGreenDeployment#source_username}.</summary>
        [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}")]
        string SourceUsername
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_mode MysqlBlueGreenDeployment#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        string SslMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#applier_username MysqlBlueGreenDeployment#applier_username}.</summary>
        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplierUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_ca_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_ca_certificate MysqlBlueGreenDeployment#ssl_ca_certificate}
        /// </remarks>
        [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate? SslCaCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlBlueGreenDeploymentChannelDetails), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_password MysqlBlueGreenDeployment#source_password}.</summary>
            [JsiiProperty(name: "sourcePassword", typeJson: "{\"primitive\":\"string\"}")]
            public string SourcePassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#source_username MysqlBlueGreenDeployment#source_username}.</summary>
            [JsiiProperty(name: "sourceUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_mode MysqlBlueGreenDeployment#ssl_mode}.</summary>
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
            public string SslMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#applier_username MysqlBlueGreenDeployment#applier_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplierUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ssl_ca_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#ssl_ca_certificate MysqlBlueGreenDeployment#ssl_ca_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslCaCertificate", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate\"}", isOptional: true)]
            public oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate? SslCaCertificate
            {
                get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate?>();
            }
        }
    }
}
