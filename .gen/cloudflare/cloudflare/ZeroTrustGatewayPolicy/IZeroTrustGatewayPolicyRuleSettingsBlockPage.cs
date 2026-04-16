using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsBlockPage), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage")]
    public interface IZeroTrustGatewayPolicyRuleSettingsBlockPage
    {
        /// <summary>Specify the URI to which the user is redirected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#target_uri ZeroTrustGatewayPolicy#target_uri}
        /// </remarks>
        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
        string TargetUri
        {
            get;
        }

        /// <summary>Specify whether to pass the context information as query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#include_context ZeroTrustGatewayPolicy#include_context}
        /// </remarks>
        [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeContext
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsBlockPage), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the URI to which the user is redirected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#target_uri ZeroTrustGatewayPolicy#target_uri}
            /// </remarks>
            [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specify whether to pass the context information as query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#include_context ZeroTrustGatewayPolicy#include_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeContext
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
