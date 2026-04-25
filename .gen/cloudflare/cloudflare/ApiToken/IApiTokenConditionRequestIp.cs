using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiInterface(nativeType: typeof(IApiTokenConditionRequestIp), fullyQualifiedName: "cloudflare.apiToken.ApiTokenConditionRequestIp")]
    public interface IApiTokenConditionRequestIp
    {
        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#in ApiToken#in}
        /// </remarks>
        [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? In
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#not_in ApiToken#not_in}
        /// </remarks>
        [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiTokenConditionRequestIp), fullyQualifiedName: "cloudflare.apiToken.ApiTokenConditionRequestIp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiToken.IApiTokenConditionRequestIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#in ApiToken#in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? In
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#not_in ApiToken#not_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotIn
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
