using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiInterface(nativeType: typeof(ILambdaCapacityProviderPermissionsConfig), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderPermissionsConfig")]
    public interface ILambdaCapacityProviderPermissionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#capacity_provider_operator_role_arn LambdaCapacityProvider#capacity_provider_operator_role_arn}.</summary>
        [JsiiProperty(name: "capacityProviderOperatorRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityProviderOperatorRoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCapacityProviderPermissionsConfig), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaCapacityProvider.ILambdaCapacityProviderPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#capacity_provider_operator_role_arn LambdaCapacityProvider#capacity_provider_operator_role_arn}.</summary>
            [JsiiProperty(name: "capacityProviderOperatorRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityProviderOperatorRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
