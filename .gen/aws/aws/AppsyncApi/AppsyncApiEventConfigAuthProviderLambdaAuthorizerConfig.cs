using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig")]
    public class AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig : aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#authorizer_uri AppsyncApi#authorizer_uri}.</summary>
        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthorizerUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#authorizer_result_ttl_in_seconds AppsyncApi#authorizer_result_ttl_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizerResultTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AuthorizerResultTtlInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#identity_validation_expression AppsyncApi#identity_validation_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityValidationExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityValidationExpression
        {
            get;
            set;
        }
    }
}
