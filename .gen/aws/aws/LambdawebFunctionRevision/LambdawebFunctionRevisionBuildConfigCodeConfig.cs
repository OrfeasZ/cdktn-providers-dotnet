using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    [JsiiByValue(fqn: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfig")]
    public class LambdawebFunctionRevisionBuildConfigCodeConfig : aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfig
    {
        private object? _s3Object;

        /// <summary>s3_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#s3_object LambdawebFunctionRevision#s3_object}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfigS3Object" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Object", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfigS3Object\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Object
        {
            get => _s3Object;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfigS3Object[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfigS3Object).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Object = value;
            }
        }
    }
}
