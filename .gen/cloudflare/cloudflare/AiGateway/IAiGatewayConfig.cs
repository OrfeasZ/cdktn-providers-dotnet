using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewayConfig), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayConfig")]
    public interface IAiGatewayConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#account_id AiGateway#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#cache_invalidate_on_update AiGateway#cache_invalidate_on_update}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "cacheInvalidateOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object CacheInvalidateOnUpdate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#cache_ttl AiGateway#cache_ttl}.</summary>
        [JsiiProperty(name: "cacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        double CacheTtl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#collect_logs AiGateway#collect_logs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "collectLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object CollectLogs
        {
            get;
        }

        /// <summary>gateway id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#id AiGateway#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_interval AiGateway#rate_limiting_interval}.</summary>
        [JsiiProperty(name: "rateLimitingInterval", typeJson: "{\"primitive\":\"number\"}")]
        double RateLimitingInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_limit AiGateway#rate_limiting_limit}.</summary>
        [JsiiProperty(name: "rateLimitingLimit", typeJson: "{\"primitive\":\"number\"}")]
        double RateLimitingLimit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#authentication AiGateway#authentication}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Authentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#dlp AiGateway#dlp}.</summary>
        [JsiiProperty(name: "dlp", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayDlp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewayDlp? Dlp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#guardrails AiGateway#guardrails}.</summary>
        [JsiiProperty(name: "guardrails", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewayGuardrails? Guardrails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_classification AiGateway#log_classification}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logClassification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogClassification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_management AiGateway#log_management}.</summary>
        [JsiiProperty(name: "logManagement", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "STOP_INSERTING", "DELETE_OLDEST".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_management_strategy AiGateway#log_management_strategy}
        /// </remarks>
        [JsiiProperty(name: "logManagementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogManagementStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#logpush AiGateway#logpush}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logpush
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#logpush_public_key AiGateway#logpush_public_key}.</summary>
        [JsiiProperty(name: "logpushPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogpushPublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#otel AiGateway#otel}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.AiGateway.IAiGatewayOtel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "otel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayOtel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Otel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_technique AiGateway#rate_limiting_technique}
        /// </remarks>
        [JsiiProperty(name: "rateLimitingTechnique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RateLimitingTechnique
        {
            get
            {
                return null;
            }
        }

        /// <summary>Backoff strategy for retry delays Available values: "constant", "linear", "exponential".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_backoff AiGateway#retry_backoff}
        /// </remarks>
        [JsiiProperty(name: "retryBackoff", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetryBackoff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Delay between retry attempts in milliseconds (0-5000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_delay AiGateway#retry_delay}
        /// </remarks>
        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of retry attempts for failed requests (1-5).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_max_attempts AiGateway#retry_max_attempts}
        /// </remarks>
        [JsiiProperty(name: "retryMaxAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryMaxAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#spend_limits AiGateway#spend_limits}.</summary>
        [JsiiProperty(name: "spendLimits", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewaySpendLimits? SpendLimits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#store_id AiGateway#store_id}.</summary>
        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#stripe AiGateway#stripe}.</summary>
        [JsiiProperty(name: "stripe", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayStripe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewayStripe? Stripe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how Workers AI inference calls routed through this gateway are billed.</summary>
        /// <remarks>
        /// 'postpaid' bills the account directly through Workers AI; 'unified' deducts credits via AI Gateway using neuron-based pricing and delegates billing to AI Gateway.
        /// Available values: "postpaid", "unified".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#workers_ai_billing_mode AiGateway#workers_ai_billing_mode}
        /// </remarks>
        [JsiiProperty(name: "workersAiBillingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkersAiBillingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#zdr AiGateway#zdr}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "zdr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Zdr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayConfig), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewayConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#account_id AiGateway#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#cache_invalidate_on_update AiGateway#cache_invalidate_on_update}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "cacheInvalidateOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object CacheInvalidateOnUpdate
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#cache_ttl AiGateway#cache_ttl}.</summary>
            [JsiiProperty(name: "cacheTtl", typeJson: "{\"primitive\":\"number\"}")]
            public double CacheTtl
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#collect_logs AiGateway#collect_logs}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "collectLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object CollectLogs
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>gateway id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#id AiGateway#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_interval AiGateway#rate_limiting_interval}.</summary>
            [JsiiProperty(name: "rateLimitingInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double RateLimitingInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_limit AiGateway#rate_limiting_limit}.</summary>
            [JsiiProperty(name: "rateLimitingLimit", typeJson: "{\"primitive\":\"number\"}")]
            public double RateLimitingLimit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#authentication AiGateway#authentication}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Authentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#dlp AiGateway#dlp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dlp", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayDlp\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewayDlp? Dlp
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewayDlp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#guardrails AiGateway#guardrails}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guardrails", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrails\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewayGuardrails? Guardrails
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewayGuardrails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_classification AiGateway#log_classification}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logClassification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogClassification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_management AiGateway#log_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logManagement", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogManagement
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Available values: "STOP_INSERTING", "DELETE_OLDEST".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#log_management_strategy AiGateway#log_management_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logManagementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogManagementStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#logpush AiGateway#logpush}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Logpush
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#logpush_public_key AiGateway#logpush_public_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logpushPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogpushPublicKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#otel AiGateway#otel}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.AiGateway.IAiGatewayOtel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "otel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayOtel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Otel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Available values: "fixed", "sliding".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#rate_limiting_technique AiGateway#rate_limiting_technique}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rateLimitingTechnique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RateLimitingTechnique
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Backoff strategy for retry delays Available values: "constant", "linear", "exponential".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_backoff AiGateway#retry_backoff}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryBackoff", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetryBackoff
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Delay between retry attempts in milliseconds (0-5000).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_delay AiGateway#retry_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Maximum number of retry attempts for failed requests (1-5).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#retry_max_attempts AiGateway#retry_max_attempts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryMaxAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryMaxAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#spend_limits AiGateway#spend_limits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spendLimits", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimits\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewaySpendLimits? SpendLimits
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewaySpendLimits?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#store_id AiGateway#store_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#stripe AiGateway#stripe}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stripe", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayStripe\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewayStripe? Stripe
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewayStripe?>();
            }

            /// <summary>Controls how Workers AI inference calls routed through this gateway are billed.</summary>
            /// <remarks>
            /// 'postpaid' bills the account directly through Workers AI; 'unified' deducts credits via AI Gateway using neuron-based pricing and delegates billing to AI Gateway.
            /// Available values: "postpaid", "unified".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#workers_ai_billing_mode AiGateway#workers_ai_billing_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workersAiBillingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkersAiBillingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_gateway#zdr AiGateway#zdr}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zdr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Zdr
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
