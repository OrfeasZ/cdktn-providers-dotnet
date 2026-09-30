using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeEstimateTableSizes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeEstimateTableSizes.DataSafeEstimateTableSizesTargetCredentials")]
    public class DataSafeEstimateTableSizesTargetCredentials : oci.DataSafeEstimateTableSizes.IDataSafeEstimateTableSizesTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_estimate_table_sizes#password DataSafeEstimateTableSizes#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_estimate_table_sizes#user_name DataSafeEstimateTableSizes#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
