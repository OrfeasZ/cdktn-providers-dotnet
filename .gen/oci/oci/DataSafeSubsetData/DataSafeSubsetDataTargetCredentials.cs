using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsetData
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsetData.DataSafeSubsetDataTargetCredentials")]
    public class DataSafeSubsetDataTargetCredentials : oci.DataSafeSubsetData.IDataSafeSubsetDataTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subset_data#password DataSafeSubsetData#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subset_data#user_name DataSafeSubsetData#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
