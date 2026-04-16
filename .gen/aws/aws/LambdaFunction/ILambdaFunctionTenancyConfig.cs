using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionTenancyConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionTenancyConfig")]
    public interface ILambdaFunctionTenancyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#tenant_isolation_mode LambdaFunction#tenant_isolation_mode}.</summary>
        [JsiiProperty(name: "tenantIsolationMode", typeJson: "{\"primitive\":\"string\"}")]
        string TenantIsolationMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionTenancyConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionTenancyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionTenancyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#tenant_isolation_mode LambdaFunction#tenant_isolation_mode}.</summary>
            [JsiiProperty(name: "tenantIsolationMode", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantIsolationMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
