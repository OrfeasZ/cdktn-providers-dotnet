using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewaySpendLimitsRules), fullyQualifiedName: "cloudflare.aiGateway.AiGatewaySpendLimitsRules")]
    public interface IAiGatewaySpendLimitsRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#limit AiGateway#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        /// <summary>Available values: "cost".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#limit_type AiGateway#limit_type}
        /// </remarks>
        [JsiiProperty(name: "limitType", typeJson: "{\"primitive\":\"string\"}")]
        string LimitType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#window AiGateway#window}.</summary>
        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"number\"}")]
        double Window
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#ai_gateway_provider AiGateway#ai_gateway_provider}.</summary>
        [JsiiProperty(name: "aiGatewayProvider", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesAiGatewayProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewaySpendLimitsRulesAiGatewayProvider? AiGatewayProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#enabled AiGateway#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#id AiGateway#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#metadata AiGateway#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesMetadata\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#model AiGateway#model}.</summary>
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesModel\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGateway.IAiGatewaySpendLimitsRulesModel? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#technique AiGateway#technique}
        /// </remarks>
        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Technique
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewaySpendLimitsRules), fullyQualifiedName: "cloudflare.aiGateway.AiGatewaySpendLimitsRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewaySpendLimitsRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#limit AiGateway#limit}.</summary>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Available values: "cost".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#limit_type AiGateway#limit_type}
            /// </remarks>
            [JsiiProperty(name: "limitType", typeJson: "{\"primitive\":\"string\"}")]
            public string LimitType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#window AiGateway#window}.</summary>
            [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"number\"}")]
            public double Window
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#ai_gateway_provider AiGateway#ai_gateway_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aiGatewayProvider", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesAiGatewayProvider\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewaySpendLimitsRulesAiGatewayProvider? AiGatewayProvider
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewaySpendLimitsRulesAiGatewayProvider?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#enabled AiGateway#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#id AiGateway#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#metadata AiGateway#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesMetadata\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Metadata
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#model AiGateway#model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesModel\"}", isOptional: true)]
            public cloudflare.AiGateway.IAiGatewaySpendLimitsRulesModel? Model
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewaySpendLimitsRulesModel?>();
            }

            /// <summary>Available values: "fixed", "sliding".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/ai_gateway#technique AiGateway#technique}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Technique
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
