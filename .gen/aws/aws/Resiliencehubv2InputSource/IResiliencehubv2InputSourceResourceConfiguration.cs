using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2InputSourceResourceConfiguration), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfiguration")]
    public interface IResiliencehubv2InputSourceResourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#cfn_stack_arn Resiliencehubv2InputSource#cfn_stack_arn}.</summary>
        [JsiiProperty(name: "cfnStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CfnStackArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#design_file_s3_url Resiliencehubv2InputSource#design_file_s3_url}.</summary>
        [JsiiProperty(name: "designFileS3Url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DesignFileS3Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>eks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#eks Resiliencehubv2InputSource#eks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Eks
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#resource_tag Resiliencehubv2InputSource#resource_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#tf_state_file_url Resiliencehubv2InputSource#tf_state_file_url}.</summary>
        [JsiiProperty(name: "tfStateFileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TfStateFileUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2InputSourceResourceConfiguration), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#cfn_stack_arn Resiliencehubv2InputSource#cfn_stack_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cfnStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CfnStackArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#design_file_s3_url Resiliencehubv2InputSource#design_file_s3_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "designFileS3Url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DesignFileS3Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>eks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#eks Resiliencehubv2InputSource#eks}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Eks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#resource_tag Resiliencehubv2InputSource#resource_tag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#tf_state_file_url Resiliencehubv2InputSource#tf_state_file_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tfStateFileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TfStateFileUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
