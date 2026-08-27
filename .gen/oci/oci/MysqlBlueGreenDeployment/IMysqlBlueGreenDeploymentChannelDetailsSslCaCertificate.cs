using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiInterface(nativeType: typeof(IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate")]
    public interface IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#certificate_type MysqlBlueGreenDeployment#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#contents MysqlBlueGreenDeployment#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        string Contents
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsSslCaCertificate")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetailsSslCaCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#certificate_type MysqlBlueGreenDeployment#certificate_type}.</summary>
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#contents MysqlBlueGreenDeployment#contents}.</summary>
            [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
            public string Contents
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
