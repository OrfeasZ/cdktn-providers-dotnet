using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaCapacityProvider.LambdaCapacityProviderPermissionsConfig")]
    public class LambdaCapacityProviderPermissionsConfig : aws.LambdaCapacityProvider.ILambdaCapacityProviderPermissionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#capacity_provider_operator_role_arn LambdaCapacityProvider#capacity_provider_operator_role_arn}.</summary>
        [JsiiProperty(name: "capacityProviderOperatorRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityProviderOperatorRoleArn
        {
            get;
            set;
        }
    }
}
