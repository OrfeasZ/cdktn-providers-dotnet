using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiByValue(fqn: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition")]
    public class Ec2AllowedImagesSettingsImageCriterionCreationDateCondition : aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#maximum_days_since_created Ec2AllowedImagesSettings#maximum_days_since_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumDaysSinceCreated", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumDaysSinceCreated
        {
            get;
            set;
        }
    }
}
