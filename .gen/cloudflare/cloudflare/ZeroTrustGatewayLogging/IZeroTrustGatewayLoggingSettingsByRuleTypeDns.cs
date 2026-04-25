using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayLogging
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayLoggingSettingsByRuleTypeDns), fullyQualifiedName: "cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDns")]
    public interface IZeroTrustGatewayLoggingSettingsByRuleTypeDns
    {
        /// <summary>Specify whether to log all requests to this service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_logging#log_all ZeroTrustGatewayLogging#log_all}
        /// </remarks>
        [JsiiProperty(name: "logAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify whether to log only blocking requests to this service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_logging#log_blocks ZeroTrustGatewayLogging#log_blocks}
        /// </remarks>
        [JsiiProperty(name: "logBlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogBlocks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayLoggingSettingsByRuleTypeDns), fullyQualifiedName: "cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDns")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify whether to log all requests to this service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_logging#log_all ZeroTrustGatewayLogging#log_all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify whether to log only blocking requests to this service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_logging#log_blocks ZeroTrustGatewayLogging#log_blocks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logBlocks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogBlocks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
