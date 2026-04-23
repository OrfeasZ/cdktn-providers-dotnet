using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiInterface(nativeType: typeof(IOsisPipelineConfig), fullyQualifiedName: "aws.osisPipeline.OsisPipelineConfig")]
    public interface IOsisPipelineConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#max_units OsisPipeline#max_units}.</summary>
        [JsiiProperty(name: "maxUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MaxUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#min_units OsisPipeline#min_units}.</summary>
        [JsiiProperty(name: "minUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MinUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_configuration_body OsisPipeline#pipeline_configuration_body}.</summary>
        [JsiiProperty(name: "pipelineConfigurationBody", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineConfigurationBody
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_name OsisPipeline#pipeline_name}.</summary>
        [JsiiProperty(name: "pipelineName", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineName
        {
            get;
        }

        /// <summary>buffer_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#buffer_options OsisPipeline#buffer_options}
        /// </remarks>
        [JsiiProperty(name: "bufferOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineBufferOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BufferOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_at_rest_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#encryption_at_rest_options OsisPipeline#encryption_at_rest_options}
        /// </remarks>
        [JsiiProperty(name: "encryptionAtRestOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineEncryptionAtRestOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionAtRestOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#log_publishing_options OsisPipeline#log_publishing_options}
        /// </remarks>
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogPublishingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_role_arn OsisPipeline#pipeline_role_arn}.</summary>
        [JsiiProperty(name: "pipelineRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#region OsisPipeline#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#tags OsisPipeline#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#timeouts OsisPipeline#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.osisPipeline.OsisPipelineTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OsisPipeline.IOsisPipelineTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#vpc_options OsisPipeline#vpc_options}
        /// </remarks>
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineVpcOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VpcOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsisPipelineConfig), fullyQualifiedName: "aws.osisPipeline.OsisPipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OsisPipeline.IOsisPipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#max_units OsisPipeline#max_units}.</summary>
            [JsiiProperty(name: "maxUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#min_units OsisPipeline#min_units}.</summary>
            [JsiiProperty(name: "minUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MinUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_configuration_body OsisPipeline#pipeline_configuration_body}.</summary>
            [JsiiProperty(name: "pipelineConfigurationBody", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineConfigurationBody
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_name OsisPipeline#pipeline_name}.</summary>
            [JsiiProperty(name: "pipelineName", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>buffer_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#buffer_options OsisPipeline#buffer_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bufferOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineBufferOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BufferOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>encryption_at_rest_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#encryption_at_rest_options OsisPipeline#encryption_at_rest_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtRestOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineEncryptionAtRestOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EncryptionAtRestOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_publishing_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#log_publishing_options OsisPipeline#log_publishing_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogPublishingOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#pipeline_role_arn OsisPipeline#pipeline_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#region OsisPipeline#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#tags OsisPipeline#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#timeouts OsisPipeline#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.osisPipeline.OsisPipelineTimeouts\"}", isOptional: true)]
            public aws.OsisPipeline.IOsisPipelineTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OsisPipeline.IOsisPipelineTimeouts?>();
            }

            /// <summary>vpc_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/osis_pipeline#vpc_options OsisPipeline#vpc_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineVpcOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VpcOptions
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
