using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiInterface(nativeType: typeof(IEc2AllowedImagesSettingsImageCriterion), fullyQualifiedName: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterion")]
    public interface IEc2AllowedImagesSettingsImageCriterion
    {
        /// <summary>creation_date_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#creation_date_condition Ec2AllowedImagesSettings#creation_date_condition}
        /// </remarks>
        [JsiiProperty(name: "creationDateCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreationDateCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>deprecation_time_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#deprecation_time_condition Ec2AllowedImagesSettings#deprecation_time_condition}
        /// </remarks>
        [JsiiProperty(name: "deprecationTimeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeprecationTimeCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_names Ec2AllowedImagesSettings#image_names}.</summary>
        [JsiiProperty(name: "imageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ImageNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_providers Ec2AllowedImagesSettings#image_providers}.</summary>
        [JsiiProperty(name: "imageProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ImageProviders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#marketplace_product_codes Ec2AllowedImagesSettings#marketplace_product_codes}.</summary>
        [JsiiProperty(name: "marketplaceProductCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MarketplaceProductCodes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2AllowedImagesSettingsImageCriterion), fullyQualifiedName: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterion")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>creation_date_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#creation_date_condition Ec2AllowedImagesSettings#creation_date_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creationDateCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreationDateCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>deprecation_time_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#deprecation_time_condition Ec2AllowedImagesSettings#deprecation_time_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecationTimeCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeprecationTimeCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_names Ec2AllowedImagesSettings#image_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ImageNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#image_providers Ec2AllowedImagesSettings#image_providers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ImageProviders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_allowed_images_settings#marketplace_product_codes Ec2AllowedImagesSettings#marketplace_product_codes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "marketplaceProductCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MarketplaceProductCodes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
