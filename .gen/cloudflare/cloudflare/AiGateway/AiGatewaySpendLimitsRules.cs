using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiGateway.AiGatewaySpendLimitsRules")]
    public class AiGatewaySpendLimitsRules : cloudflare.AiGateway.IAiGatewaySpendLimitsRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#limit AiGateway#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public double Limit
        {
            get;
            set;
        }

        /// <summary>Available values: "cost".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#limit_type AiGateway#limit_type}
        /// </remarks>
        [JsiiProperty(name: "limitType", typeJson: "{\"primitive\":\"string\"}")]
        public string LimitType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#window AiGateway#window}.</summary>
        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"number\"}")]
        public double Window
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#ai_gateway_provider AiGateway#ai_gateway_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aiGatewayProvider", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesAiGatewayProvider\"}", isOptional: true)]
        public cloudflare.AiGateway.IAiGatewaySpendLimitsRulesAiGatewayProvider? AiGatewayProvider
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#enabled AiGateway#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#id AiGateway#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _metadata;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#metadata AiGateway#metadata}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.AiGateway.IAiGatewaySpendLimitsRulesMetadata" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesMetadata\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Metadata
        {
            get => _metadata;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.AiGateway.IAiGatewaySpendLimitsRulesMetadata> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.AiGateway.IAiGatewaySpendLimitsRulesMetadata).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metadata = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#model AiGateway#model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewaySpendLimitsRulesModel\"}", isOptional: true)]
        public cloudflare.AiGateway.IAiGatewaySpendLimitsRulesModel? Model
        {
            get;
            set;
        }

        /// <summary>Available values: "fixed", "sliding".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ai_gateway#technique AiGateway#technique}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Technique
        {
            get;
            set;
        }
    }
}
