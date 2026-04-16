using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiInterface(nativeType: typeof(IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition), fullyQualifiedName: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition")]
    public interface IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ec2_allowed_images_settings#maximum_days_since_deprecated Ec2AllowedImagesSettings#maximum_days_since_deprecated}.</summary>
        [JsiiProperty(name: "maximumDaysSinceDeprecated", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumDaysSinceDeprecated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition), fullyQualifiedName: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ec2_allowed_images_settings#maximum_days_since_deprecated Ec2AllowedImagesSettings#maximum_days_since_deprecated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumDaysSinceDeprecated", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumDaysSinceDeprecated
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
