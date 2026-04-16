using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation")]
    public class CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#event_type CloudfrontMultitenantDistribution#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        public string EventType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#lambda_function_arn CloudfrontMultitenantDistribution#lambda_function_arn}.</summary>
        [JsiiProperty(name: "lambdaFunctionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LambdaFunctionArn
        {
            get;
            set;
        }

        private object? _includeBody;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#include_body CloudfrontMultitenantDistribution#include_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeBody
        {
            get => _includeBody;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeBody = value;
            }
        }
    }
}
