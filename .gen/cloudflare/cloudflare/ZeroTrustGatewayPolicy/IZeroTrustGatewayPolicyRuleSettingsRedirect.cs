using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsRedirect), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect")]
    public interface IZeroTrustGatewayPolicyRuleSettingsRedirect
    {
        /// <summary>URI to which the user will be redirected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#target_uri ZeroTrustGatewayPolicy#target_uri}
        /// </remarks>
        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
        string TargetUri
        {
            get;
        }

        /// <summary>If true, context information will be passed as query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#include_context ZeroTrustGatewayPolicy#include_context}
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

        /// <summary>If true, the path and query parameters from the original request will be appended to target_uri.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#preserve_path_and_query ZeroTrustGatewayPolicy#preserve_path_and_query}
        /// </remarks>
        [JsiiProperty(name: "preservePathAndQuery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreservePathAndQuery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsRedirect), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>URI to which the user will be redirected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#target_uri ZeroTrustGatewayPolicy#target_uri}
            /// </remarks>
            [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If true, context information will be passed as query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#include_context ZeroTrustGatewayPolicy#include_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeContext
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If true, the path and query parameters from the original request will be appended to target_uri.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#preserve_path_and_query ZeroTrustGatewayPolicy#preserve_path_and_query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preservePathAndQuery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreservePathAndQuery
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
