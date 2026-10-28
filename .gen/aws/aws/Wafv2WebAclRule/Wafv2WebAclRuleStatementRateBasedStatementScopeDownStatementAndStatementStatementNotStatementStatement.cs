using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatement
    {
        private object? _asnMatchStatement;

        /// <summary>asn_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#asn_match_statement Wafv2WebAclRuleA#asn_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementAsnMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asnMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementAsnMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AsnMatchStatement
        {
            get => _asnMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementAsnMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementAsnMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _asnMatchStatement = value;
            }
        }

        private object? _byteMatchStatement;

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#byte_match_statement Wafv2WebAclRuleA#byte_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementByteMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ByteMatchStatement
        {
            get => _byteMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementByteMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementByteMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _byteMatchStatement = value;
            }
        }

        private object? _geoMatchStatement;

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#geo_match_statement Wafv2WebAclRuleA#geo_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementGeoMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeoMatchStatement
        {
            get => _geoMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementGeoMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementGeoMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geoMatchStatement = value;
            }
        }

        private object? _ipSetReferenceStatement;

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ip_set_reference_statement Wafv2WebAclRuleA#ip_set_reference_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpSetReferenceStatement
        {
            get => _ipSetReferenceStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementIpSetReferenceStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipSetReferenceStatement = value;
            }
        }

        private object? _labelMatchStatement;

        /// <summary>label_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#label_match_statement Wafv2WebAclRuleA#label_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementLabelMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementLabelMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LabelMatchStatement
        {
            get => _labelMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementLabelMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementLabelMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _labelMatchStatement = value;
            }
        }

        private object? _regexMatchStatement;

        /// <summary>regex_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#regex_match_statement Wafv2WebAclRuleA#regex_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegexMatchStatement
        {
            get => _regexMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexMatchStatement = value;
            }
        }

        private object? _regexPatternSetReferenceStatement;

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#regex_pattern_set_reference_statement Wafv2WebAclRuleA#regex_pattern_set_reference_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegexPatternSetReferenceStatement
        {
            get => _regexPatternSetReferenceStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementRegexPatternSetReferenceStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexPatternSetReferenceStatement = value;
            }
        }

        private object? _sizeConstraintStatement;

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#size_constraint_statement Wafv2WebAclRuleA#size_constraint_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSizeConstraintStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SizeConstraintStatement
        {
            get => _sizeConstraintStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSizeConstraintStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSizeConstraintStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sizeConstraintStatement = value;
            }
        }

        private object? _sqliMatchStatement;

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#sqli_match_statement Wafv2WebAclRuleA#sqli_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSqliMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SqliMatchStatement
        {
            get => _sqliMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSqliMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementSqliMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sqliMatchStatement = value;
            }
        }

        private object? _xssMatchStatement;

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#xss_match_statement Wafv2WebAclRuleA#xss_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementXssMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? XssMatchStatement
        {
            get => _xssMatchStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementXssMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementNotStatementStatementXssMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _xssMatchStatement = value;
            }
        }
    }
}
