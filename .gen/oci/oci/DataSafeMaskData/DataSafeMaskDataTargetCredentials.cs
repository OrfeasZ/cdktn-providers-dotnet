using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskData
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeMaskData.DataSafeMaskDataTargetCredentials")]
    public class DataSafeMaskDataTargetCredentials : oci.DataSafeMaskData.IDataSafeMaskDataTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#password DataSafeMaskData#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#user_name DataSafeMaskData#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
