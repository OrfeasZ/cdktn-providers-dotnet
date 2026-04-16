using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiInterface(nativeType: typeof(ITokenValidationRulesPosition), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesPosition")]
    public interface ITokenValidationRulesPosition
    {
        /// <summary>Move rule to after rule with this ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#after TokenValidationRules#after}
        /// </remarks>
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? After
        {
            get
            {
                return null;
            }
        }

        /// <summary>Move rule to before rule with this ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#before TokenValidationRules#before}
        /// </remarks>
        [JsiiProperty(name: "before", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Before
        {
            get
            {
                return null;
            }
        }

        /// <summary>Move rule to this position.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#index TokenValidationRules#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Index
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationRulesPosition), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesPosition")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationRules.ITokenValidationRulesPosition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Move rule to after rule with this ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#after TokenValidationRules#after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? After
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Move rule to before rule with this ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#before TokenValidationRules#before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "before", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Before
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Move rule to this position.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#index TokenValidationRules#index}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Index
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
