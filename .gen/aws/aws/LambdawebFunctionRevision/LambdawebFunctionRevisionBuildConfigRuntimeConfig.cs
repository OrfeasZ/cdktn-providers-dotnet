using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigRuntimeConfig")]
    public class LambdawebFunctionRevisionBuildConfigRuntimeConfig : aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#runtime LambdawebFunctionRevision#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public string Runtime
        {
            get;
            set;
        }
    }
}
