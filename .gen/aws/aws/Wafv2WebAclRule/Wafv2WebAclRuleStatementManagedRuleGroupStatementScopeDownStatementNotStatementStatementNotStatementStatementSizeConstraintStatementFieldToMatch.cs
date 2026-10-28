using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch
    {
        private object? _allQueryArguments;

        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#all_query_arguments Wafv2WebAclRuleA#all_query_arguments}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllQueryArguments
        {
            get => _allQueryArguments;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allQueryArguments = value;
            }
        }

        private object? _body;

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#body Wafv2WebAclRuleA#body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Body
        {
            get => _body;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _body = value;
            }
        }

        private object? _cookies;

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#cookies Wafv2WebAclRuleA#cookies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchCookies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Cookies
        {
            get => _cookies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchCookies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchCookies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cookies = value;
            }
        }

        private object? _headerOrder;

        /// <summary>header_order block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#header_order Wafv2WebAclRuleA#header_order}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerOrder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HeaderOrder
        {
            get => _headerOrder;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headerOrder = value;
            }
        }

        private object? _headers;

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#headers Wafv2WebAclRuleA#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        private object? _ja3Fingerprint;

        /// <summary>ja3_fingerprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja3_fingerprint Wafv2WebAclRuleA#ja3_fingerprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja3Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ja3Fingerprint
        {
            get => _ja3Fingerprint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ja3Fingerprint = value;
            }
        }

        private object? _ja4Fingerprint;

        /// <summary>ja4_fingerprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja4_fingerprint Wafv2WebAclRuleA#ja4_fingerprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja4Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ja4Fingerprint
        {
            get => _ja4Fingerprint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ja4Fingerprint = value;
            }
        }

        private object? _jsonBody;

        /// <summary>json_body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#json_body Wafv2WebAclRuleA#json_body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJsonBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsonBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JsonBody
        {
            get => _jsonBody;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJsonBody[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchJsonBody).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jsonBody = value;
            }
        }

        private object? _method;

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#method Wafv2WebAclRuleA#method}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Method
        {
            get => _method;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _method = value;
            }
        }

        private object? _queryString;

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#query_string Wafv2WebAclRuleA#query_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryString
        {
            get => _queryString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryString = value;
            }
        }

        private object? _singleHeader;

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_header Wafv2WebAclRuleA#single_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SingleHeader
        {
            get => _singleHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _singleHeader = value;
            }
        }

        private object? _singleQueryArgument;

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_query_argument Wafv2WebAclRuleA#single_query_argument}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SingleQueryArgument
        {
            get => _singleQueryArgument;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _singleQueryArgument = value;
            }
        }

        private object? _uriFragment;

        /// <summary>uri_fragment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_fragment Wafv2WebAclRuleA#uri_fragment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriFragment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriFragment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UriFragment
        {
            get => _uriFragment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriFragment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriFragment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uriFragment = value;
            }
        }

        private object? _uriPath;

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_path Wafv2WebAclRuleA#uri_path}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UriPath
        {
            get => _uriPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uriPath = value;
            }
        }
    }
}
