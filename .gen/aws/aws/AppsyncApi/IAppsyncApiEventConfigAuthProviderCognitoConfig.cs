using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfigAuthProviderCognitoConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig")]
    public interface IAppsyncApiEventConfigAuthProviderCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#aws_region AppsyncApi#aws_region}.</summary>
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        string AwsRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#user_pool_id AppsyncApi#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#app_id_client_regex AppsyncApi#app_id_client_regex}.</summary>
        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppIdClientRegex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfigAuthProviderCognitoConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#aws_region AppsyncApi#aws_region}.</summary>
            [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string AwsRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#user_pool_id AppsyncApi#user_pool_id}.</summary>
            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#app_id_client_regex AppsyncApi#app_id_client_regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppIdClientRegex
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
