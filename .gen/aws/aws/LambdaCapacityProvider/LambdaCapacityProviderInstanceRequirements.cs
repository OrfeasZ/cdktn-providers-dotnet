using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiByValue(fqn: "aws.lambdaCapacityProvider.LambdaCapacityProviderInstanceRequirements")]
    public class LambdaCapacityProviderInstanceRequirements : aws.LambdaCapacityProvider.ILambdaCapacityProviderInstanceRequirements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#allowed_instance_types LambdaCapacityProvider#allowed_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#architectures LambdaCapacityProvider#architectures}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Architectures
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#excluded_instance_types LambdaCapacityProvider#excluded_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedInstanceTypes
        {
            get;
            set;
        }
    }
}
