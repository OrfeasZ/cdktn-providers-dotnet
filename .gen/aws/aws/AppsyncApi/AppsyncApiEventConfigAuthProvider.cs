using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfigAuthProvider")]
    public class AppsyncApiEventConfigAuthProvider : aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_type AppsyncApi#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthType
        {
            get;
            set;
        }

        private object? _cognitoConfig;

        /// <summary>cognito_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#cognito_config AppsyncApi#cognito_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CognitoConfig
        {
            get => _cognitoConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cognitoConfig = value;
            }
        }

        private object? _lambdaAuthorizerConfig;

        /// <summary>lambda_authorizer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#lambda_authorizer_config AppsyncApi#lambda_authorizer_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAuthorizerConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaAuthorizerConfig
        {
            get => _lambdaAuthorizerConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaAuthorizerConfig = value;
            }
        }

        private object? _openidConnectConfig;

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#openid_connect_config AppsyncApi#openid_connect_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenidConnectConfig
        {
            get => _openidConnectConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openidConnectConfig = value;
            }
        }
    }
}
