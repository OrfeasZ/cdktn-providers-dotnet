using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfig")]
    public interface IAppsyncApiEventConfig
    {
        /// <summary>auth_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_provider AppsyncApi#auth_provider}
        /// </remarks>
        [JsiiProperty(name: "authProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#connection_auth_mode AppsyncApi#connection_auth_mode}
        /// </remarks>
        [JsiiProperty(name: "connectionAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionAuthMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_publish_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_publish_auth_mode AppsyncApi#default_publish_auth_mode}
        /// </remarks>
        [JsiiProperty(name: "defaultPublishAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultPublishAuthMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_subscribe_auth_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_subscribe_auth_mode AppsyncApi#default_subscribe_auth_mode}
        /// </remarks>
        [JsiiProperty(name: "defaultSubscribeAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultSubscribeAuthMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#log_config AppsyncApi#log_config}
        /// </remarks>
        [JsiiProperty(name: "logConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auth_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_provider AppsyncApi#auth_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthProvider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>connection_auth_mode block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#connection_auth_mode AppsyncApi#connection_auth_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionAuthMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_publish_auth_mode block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_publish_auth_mode AppsyncApi#default_publish_auth_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPublishAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultPublishAuthMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_subscribe_auth_mode block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#default_subscribe_auth_mode AppsyncApi#default_subscribe_auth_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSubscribeAuthMode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultSubscribeAuthMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#log_config AppsyncApi#log_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
