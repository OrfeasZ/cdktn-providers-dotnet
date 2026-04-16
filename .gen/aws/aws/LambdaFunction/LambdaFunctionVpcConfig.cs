using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionVpcConfig")]
    public class LambdaFunctionVpcConfig : aws.LambdaFunction.ILambdaFunctionVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#security_group_ids LambdaFunction#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#subnet_ids LambdaFunction#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        private object? _ipv6AllowedForDualStack;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#ipv6_allowed_for_dual_stack LambdaFunction#ipv6_allowed_for_dual_stack}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6AllowedForDualStack", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Ipv6AllowedForDualStack
        {
            get => _ipv6AllowedForDualStack;
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
                _ipv6AllowedForDualStack = value;
            }
        }
    }
}
