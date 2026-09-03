using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsMicrovmLogging), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging")]
    public interface ILambdamicrovmsMicrovmLogging
    {
        /// <summary>cloudwatch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#cloudwatch LambdamicrovmsMicrovm#cloudwatch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cloudwatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cloudwatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>disabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#disabled LambdamicrovmsMicrovm#disabled}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingDisabled" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingDisabled\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsMicrovmLogging), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#cloudwatch LambdamicrovmsMicrovm#cloudwatch}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cloudwatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>disabled block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#disabled LambdamicrovmsMicrovm#disabled}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingDisabled" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingDisabled\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
