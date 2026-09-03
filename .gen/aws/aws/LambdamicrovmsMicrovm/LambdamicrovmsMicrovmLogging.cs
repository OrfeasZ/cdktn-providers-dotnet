using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiByValue(fqn: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLogging")]
    public class LambdamicrovmsMicrovmLogging : aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLogging
    {
        private object? _cloudwatch;

        /// <summary>cloudwatch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#cloudwatch LambdamicrovmsMicrovm#cloudwatch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Cloudwatch
        {
            get => _cloudwatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloudwatch = value;
            }
        }

        private object? _disabled;

        /// <summary>disabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#disabled LambdamicrovmsMicrovm#disabled}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingDisabled" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingDisabled\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingDisabled[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingDisabled).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disabled = value;
            }
        }
    }
}
