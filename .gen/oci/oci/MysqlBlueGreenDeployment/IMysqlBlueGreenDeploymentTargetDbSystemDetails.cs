using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiInterface(nativeType: typeof(IMysqlBlueGreenDeploymentTargetDbSystemDetails), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails")]
    public interface IMysqlBlueGreenDeploymentTargetDbSystemDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#mysql_version MysqlBlueGreenDeployment#mysql_version}.</summary>
        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        string MysqlVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#configuration_id MysqlBlueGreenDeployment#configuration_id}.</summary>
        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#data_storage_size_in_gb MysqlBlueGreenDeployment#data_storage_size_in_gb}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataStorageSizeInGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#shape_name MysqlBlueGreenDeployment#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShapeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlBlueGreenDeploymentTargetDbSystemDetails), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#mysql_version MysqlBlueGreenDeployment#mysql_version}.</summary>
            [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string MysqlVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#configuration_id MysqlBlueGreenDeployment#configuration_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#data_storage_size_in_gb MysqlBlueGreenDeployment#data_storage_size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataStorageSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#shape_name MysqlBlueGreenDeployment#shape_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShapeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
