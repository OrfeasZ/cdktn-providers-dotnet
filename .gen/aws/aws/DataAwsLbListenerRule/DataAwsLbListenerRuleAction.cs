using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
    public class DataAwsLbListenerRuleAction : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction
    {
        private object? _authenticateCognito;

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#authenticate_cognito DataAwsLbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthenticateCognito
        {
            get => _authenticateCognito;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionAuthenticateCognito[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionAuthenticateCognito).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticateCognito = value;
            }
        }

        private object? _authenticateOidc;

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#authenticate_oidc DataAwsLbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthenticateOidc
        {
            get => _authenticateOidc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionAuthenticateOidc[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionAuthenticateOidc).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticateOidc = value;
            }
        }

        private object? _fixedResponse;

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#fixed_response DataAwsLbListenerRule#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FixedResponse
        {
            get => _fixedResponse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionFixedResponse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionFixedResponse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fixedResponse = value;
            }
        }

        private object? _forward;

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Forward
        {
            get => _forward;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forward = value;
            }
        }

        private object? _jwtValidation;

        /// <summary>jwt_validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#jwt_validation DataAwsLbListenerRule#jwt_validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jwtValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JwtValidation
        {
            get => _jwtValidation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionJwtValidation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionJwtValidation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jwtValidation = value;
            }
        }

        private object? _redirect;

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#redirect DataAwsLbListenerRule#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Redirect
        {
            get => _redirect;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionRedirect[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionRedirect).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirect = value;
            }
        }
    }
}
