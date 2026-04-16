using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfig")]
    public class AppsyncApiEventConfig : aws.AppsyncApi.IAppsyncApiEventConfig
    {
        private object? _authProvider;

        /// <summary>auth_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_provider AppsyncApi#auth_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthProvider
        {
            get => _authProvider;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authProvider = value;
            }
        }

        private object? _connectionAuthMode;

        /// <summary>connection_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#connection_auth_mode AppsyncApi#connection_auth_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConnectionAuthMode
        {
            get => _connectionAuthMode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigConnectionAuthMode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigConnectionAuthMode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectionAuthMode = value;
            }
        }

        private object? _defaultPublishAuthMode;

        /// <summary>default_publish_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_publish_auth_mode AppsyncApi#default_publish_auth_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPublishAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefaultPublishAuthMode
        {
            get => _defaultPublishAuthMode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigDefaultPublishAuthMode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultPublishAuthMode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultPublishAuthMode = value;
            }
        }

        private object? _defaultSubscribeAuthMode;

        /// <summary>default_subscribe_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_subscribe_auth_mode AppsyncApi#default_subscribe_auth_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSubscribeAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefaultSubscribeAuthMode
        {
            get => _defaultSubscribeAuthMode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultSubscribeAuthMode = value;
            }
        }

        private object? _logConfig;

        /// <summary>log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#log_config AppsyncApi#log_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogConfig
        {
            get => _logConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncApi.IAppsyncApiEventConfigLogConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigLogConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logConfig = value;
            }
        }
    }
}
