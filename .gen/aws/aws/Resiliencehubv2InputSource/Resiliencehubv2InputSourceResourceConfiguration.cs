using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiByValue(fqn: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfiguration")]
    public class Resiliencehubv2InputSourceResourceConfiguration : aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#cfn_stack_arn Resiliencehubv2InputSource#cfn_stack_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cfnStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CfnStackArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#design_file_s3_url Resiliencehubv2InputSource#design_file_s3_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "designFileS3Url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DesignFileS3Url
        {
            get;
            set;
        }

        private object? _eks;

        /// <summary>eks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#eks Resiliencehubv2InputSource#eks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Eks
        {
            get => _eks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eks = value;
            }
        }

        private object? _resourceTag;

        /// <summary>resource_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#resource_tag Resiliencehubv2InputSource#resource_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceTag
        {
            get => _resourceTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceTag = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#tf_state_file_url Resiliencehubv2InputSource#tf_state_file_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tfStateFileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TfStateFileUrl
        {
            get;
            set;
        }
    }
}
