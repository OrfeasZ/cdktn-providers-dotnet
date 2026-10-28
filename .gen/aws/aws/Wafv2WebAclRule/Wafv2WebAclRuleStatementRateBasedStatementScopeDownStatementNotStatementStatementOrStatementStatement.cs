using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatement
    {
        private object? _asnMatchStatement;

        /// <summary>asn_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#asn_match_statement Wafv2WebAclRuleA#asn_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementAsnMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asnMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementAsnMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementAsnMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementAsnMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _asnMatchStatement = value;
            }
        }

        private object? _byteMatchStatement;

        /// <summary>byte_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#byte_match_statement Wafv2WebAclRuleA#byte_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementByteMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementByteMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementByteMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _byteMatchStatement = value;
            }
        }

        private object? _geoMatchStatement;

        /// <summary>geo_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#geo_match_statement Wafv2WebAclRuleA#geo_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementGeoMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementGeoMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementGeoMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geoMatchStatement = value;
            }
        }

        private object? _ipSetReferenceStatement;

        /// <summary>ip_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ip_set_reference_statement Wafv2WebAclRuleA#ip_set_reference_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipSetReferenceStatement = value;
            }
        }

        private object? _labelMatchStatement;

        /// <summary>label_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#label_match_statement Wafv2WebAclRuleA#label_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementLabelMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementLabelMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementLabelMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementLabelMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _labelMatchStatement = value;
            }
        }

        private object? _regexMatchStatement;

        /// <summary>regex_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#regex_match_statement Wafv2WebAclRuleA#regex_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexMatchStatement = value;
            }
        }

        private object? _regexPatternSetReferenceStatement;

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#regex_pattern_set_reference_statement Wafv2WebAclRuleA#regex_pattern_set_reference_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexPatternSetReferenceStatement = value;
            }
        }

        private object? _sizeConstraintStatement;

        /// <summary>size_constraint_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#size_constraint_statement Wafv2WebAclRuleA#size_constraint_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSizeConstraintStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSizeConstraintStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSizeConstraintStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sizeConstraintStatement = value;
            }
        }

        private object? _sqliMatchStatement;

        /// <summary>sqli_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#sqli_match_statement Wafv2WebAclRuleA#sqli_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSqliMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSqliMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementSqliMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sqliMatchStatement = value;
            }
        }

        private object? _xssMatchStatement;

        /// <summary>xss_match_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#xss_match_statement Wafv2WebAclRuleA#xss_match_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementXssMatchStatement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementXssMatchStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementStatementXssMatchStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _xssMatchStatement = value;
            }
        }
    }
}
