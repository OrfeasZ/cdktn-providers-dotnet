using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionTenancyConfig")]
    public class LambdaFunctionTenancyConfig : aws.LambdaFunction.ILambdaFunctionTenancyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#tenant_isolation_mode LambdaFunction#tenant_isolation_mode}.</summary>
        [JsiiProperty(name: "tenantIsolationMode", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantIsolationMode
        {
            get;
            set;
        }
    }
}
