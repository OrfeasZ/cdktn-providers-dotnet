using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig")]
    public interface IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#authorizer_uri AppsyncApi#authorizer_uri}.</summary>
        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizerUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#authorizer_result_ttl_in_seconds AppsyncApi#authorizer_result_ttl_in_seconds}.</summary>
        [JsiiProperty(name: "authorizerResultTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AuthorizerResultTtlInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#identity_validation_expression AppsyncApi#identity_validation_expression}.</summary>
        [JsiiProperty(name: "identityValidationExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityValidationExpression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#authorizer_uri AppsyncApi#authorizer_uri}.</summary>
            [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizerUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#authorizer_result_ttl_in_seconds AppsyncApi#authorizer_result_ttl_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizerResultTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AuthorizerResultTtlInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#identity_validation_expression AppsyncApi#identity_validation_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityValidationExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityValidationExpression
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
