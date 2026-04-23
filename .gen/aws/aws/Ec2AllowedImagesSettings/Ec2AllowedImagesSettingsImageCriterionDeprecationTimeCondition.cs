using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiByValue(fqn: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition")]
    public class Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition : aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ec2_allowed_images_settings#maximum_days_since_deprecated Ec2AllowedImagesSettings#maximum_days_since_deprecated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumDaysSinceDeprecated", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumDaysSinceDeprecated
        {
            get;
            set;
        }
    }
}
