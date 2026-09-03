using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails")]
    public class MysqlBlueGreenDeploymentTargetDbSystemDetails : oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#mysql_version MysqlBlueGreenDeployment#mysql_version}.</summary>
        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string MysqlVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#configuration_id MysqlBlueGreenDeployment#configuration_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#data_storage_size_in_gb MysqlBlueGreenDeployment#data_storage_size_in_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataStorageSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_blue_green_deployment#shape_name MysqlBlueGreenDeployment#shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShapeName
        {
            get;
            set;
        }
    }
}
