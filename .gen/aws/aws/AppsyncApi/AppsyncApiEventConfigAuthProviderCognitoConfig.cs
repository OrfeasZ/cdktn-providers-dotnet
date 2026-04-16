using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig")]
    public class AppsyncApiEventConfigAuthProviderCognitoConfig : aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#aws_region AppsyncApi#aws_region}.</summary>
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#user_pool_id AppsyncApi#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserPoolId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#app_id_client_regex AppsyncApi#app_id_client_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppIdClientRegex
        {
            get;
            set;
        }
    }
}
