using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiInterface(nativeType: typeof(IAccountTokenConditionRequestIp), fullyQualifiedName: "cloudflare.accountToken.AccountTokenConditionRequestIp")]
    public interface IAccountTokenConditionRequestIp
    {
        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#in AccountToken#in}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#not_in AccountToken#not_in}
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

        [JsiiTypeProxy(nativeType: typeof(IAccountTokenConditionRequestIp), fullyQualifiedName: "cloudflare.accountToken.AccountTokenConditionRequestIp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountToken.IAccountTokenConditionRequestIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#in AccountToken#in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? In
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#not_in AccountToken#not_in}
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
