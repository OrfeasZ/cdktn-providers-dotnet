using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiByValue(fqn: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterion")]
    public class Ec2AllowedImagesSettingsImageCriterion : aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterion
    {
        private object? _creationDateCondition;

        /// <summary>creation_date_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#creation_date_condition Ec2AllowedImagesSettings#creation_date_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creationDateCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreationDateCondition
        {
            get => _creationDateCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _creationDateCondition = value;
            }
        }

        private object? _deprecationTimeCondition;

        /// <summary>deprecation_time_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#deprecation_time_condition Ec2AllowedImagesSettings#deprecation_time_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecationTimeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeprecationTimeCondition
        {
            get => _deprecationTimeCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deprecationTimeCondition = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_names Ec2AllowedImagesSettings#image_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ImageNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_providers Ec2AllowedImagesSettings#image_providers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ImageProviders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#marketplace_product_codes Ec2AllowedImagesSettings#marketplace_product_codes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "marketplaceProductCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MarketplaceProductCodes
        {
            get;
            set;
        }
    }
}
