using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaCapacityProvider.LambdaCapacityProviderVpcConfig")]
    public class LambdaCapacityProviderVpcConfig : aws.LambdaCapacityProvider.ILambdaCapacityProviderVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#security_group_ids LambdaCapacityProvider#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#subnet_ids LambdaCapacityProvider#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }
    }
}
