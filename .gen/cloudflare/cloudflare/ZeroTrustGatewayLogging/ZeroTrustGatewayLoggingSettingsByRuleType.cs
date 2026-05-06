using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayLogging
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleType")]
    public class ZeroTrustGatewayLoggingSettingsByRuleType : cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_logging#dns ZeroTrustGatewayLogging#dns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDns\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeDns? Dns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_logging#http ZeroTrustGatewayLogging#http}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttp\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeHttp? Http
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_logging#l4 ZeroTrustGatewayLogging#l4}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "l4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeL4? L4
        {
            get;
            set;
        }
    }
}
