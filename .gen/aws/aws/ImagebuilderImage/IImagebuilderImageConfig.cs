using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageConfig), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageConfig")]
    public interface IImagebuilderImageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#infrastructure_configuration_arn ImagebuilderImage#infrastructure_configuration_arn}.</summary>
        [JsiiProperty(name: "infrastructureConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string InfrastructureConfigurationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#container_recipe_arn ImagebuilderImage#container_recipe_arn}.</summary>
        [JsiiProperty(name: "containerRecipeArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerRecipeArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#distribution_configuration_arn ImagebuilderImage#distribution_configuration_arn}.</summary>
        [JsiiProperty(name: "distributionConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DistributionConfigurationArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#enhanced_image_metadata_enabled ImagebuilderImage#enhanced_image_metadata_enabled}.</summary>
        [JsiiProperty(name: "enhancedImageMetadataEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnhancedImageMetadataEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#execution_role ImagebuilderImage#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#id ImagebuilderImage#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_recipe_arn ImagebuilderImage#image_recipe_arn}.</summary>
        [JsiiProperty(name: "imageRecipeArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageRecipeArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_scanning_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_scanning_configuration ImagebuilderImage#image_scanning_configuration}
        /// </remarks>
        [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration? ImageScanningConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_tests_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_tests_configuration ImagebuilderImage#image_tests_configuration}
        /// </remarks>
        [JsiiProperty(name: "imageTestsConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageTestsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImage.IImagebuilderImageImageTestsConfiguration? ImageTestsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#logging_configuration ImagebuilderImage#logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageLoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImage.IImagebuilderImageLoggingConfiguration? LoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#region ImagebuilderImage#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#tags ImagebuilderImage#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#tags_all ImagebuilderImage#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#timeouts ImagebuilderImage#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImage.IImagebuilderImageTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>workflow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#workflow ImagebuilderImage#workflow}
        /// </remarks>
        [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageWorkflow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Workflow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageConfig), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImage.IImagebuilderImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#infrastructure_configuration_arn ImagebuilderImage#infrastructure_configuration_arn}.</summary>
            [JsiiProperty(name: "infrastructureConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string InfrastructureConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#container_recipe_arn ImagebuilderImage#container_recipe_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerRecipeArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerRecipeArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#distribution_configuration_arn ImagebuilderImage#distribution_configuration_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "distributionConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DistributionConfigurationArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#enhanced_image_metadata_enabled ImagebuilderImage#enhanced_image_metadata_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedImageMetadataEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnhancedImageMetadataEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#execution_role ImagebuilderImage#execution_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#id ImagebuilderImage#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_recipe_arn ImagebuilderImage#image_recipe_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageRecipeArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageRecipeArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>image_scanning_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_scanning_configuration ImagebuilderImage#image_scanning_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration? ImageScanningConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration?>();
            }

            /// <summary>image_tests_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#image_tests_configuration ImagebuilderImage#image_tests_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageTestsConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageTestsConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderImage.IImagebuilderImageImageTestsConfiguration? ImageTestsConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageImageTestsConfiguration?>();
            }

            /// <summary>logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#logging_configuration ImagebuilderImage#logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageLoggingConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderImage.IImagebuilderImageLoggingConfiguration? LoggingConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageLoggingConfiguration?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#region ImagebuilderImage#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#tags ImagebuilderImage#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#tags_all ImagebuilderImage#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#timeouts ImagebuilderImage#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageTimeouts\"}", isOptional: true)]
            public aws.ImagebuilderImage.IImagebuilderImageTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageTimeouts?>();
            }

            /// <summary>workflow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/imagebuilder_image#workflow ImagebuilderImage#workflow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageWorkflow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Workflow
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
