using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesSynchronizationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3FilesSynchronizationConfiguration.S3FilesSynchronizationConfigurationExpirationDataRule")]
    public class S3FilesSynchronizationConfigurationExpirationDataRule : aws.S3FilesSynchronizationConfiguration.IS3FilesSynchronizationConfigurationExpirationDataRule
    {
        /// <summary>Days after last access before data expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#days_after_last_access S3FilesSynchronizationConfiguration#days_after_last_access}
        /// </remarks>
        [JsiiProperty(name: "daysAfterLastAccess", typeJson: "{\"primitive\":\"number\"}")]
        public double DaysAfterLastAccess
        {
            get;
            set;
        }
    }
}
