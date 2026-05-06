using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentials")]
    public class DataSafeTargetDatabaseCredentials : oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#password DataSafeTargetDatabase#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#user_name DataSafeTargetDatabase#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
