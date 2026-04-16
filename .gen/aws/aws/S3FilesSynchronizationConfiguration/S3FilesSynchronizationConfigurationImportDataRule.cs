using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesSynchronizationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3FilesSynchronizationConfiguration.S3FilesSynchronizationConfigurationImportDataRule")]
    public class S3FilesSynchronizationConfigurationImportDataRule : aws.S3FilesSynchronizationConfiguration.IS3FilesSynchronizationConfigurationImportDataRule
    {
        /// <summary>S3 prefix for import.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_synchronization_configuration#prefix S3FilesSynchronizationConfiguration#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Maximum file size to import.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_synchronization_configuration#size_less_than S3FilesSynchronizationConfiguration#size_less_than}
        /// </remarks>
        [JsiiProperty(name: "sizeLessThan", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeLessThan
        {
            get;
            set;
        }

        /// <summary>Import trigger type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_synchronization_configuration#trigger S3FilesSynchronizationConfiguration#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}")]
        public string Trigger
        {
            get;
            set;
        }
    }
}
