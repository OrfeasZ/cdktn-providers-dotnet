using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleAction), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
    public interface IDataAwsLbListenerRuleAction
    {
        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#authenticate_cognito DataAwsLbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#authenticate_oidc DataAwsLbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#fixed_response DataAwsLbListenerRule#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>jwt_validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#jwt_validation DataAwsLbListenerRule#jwt_validation}
        /// </remarks>
        [JsiiProperty(name: "jwtValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JwtValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#redirect DataAwsLbListenerRule#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleAction), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authenticate_cognito block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#authenticate_cognito DataAwsLbListenerRule#authenticate_cognito}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthenticateCognito
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#authenticate_oidc DataAwsLbListenerRule#authenticate_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthenticateOidc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#fixed_response DataAwsLbListenerRule#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FixedResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Forward
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>jwt_validation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#jwt_validation DataAwsLbListenerRule#jwt_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JwtValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#redirect DataAwsLbListenerRule#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Redirect
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
