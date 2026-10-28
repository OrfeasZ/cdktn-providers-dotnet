using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#all_query_arguments Wafv2WebAclRuleA#all_query_arguments}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#body Wafv2WebAclRuleA#body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchBody" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#cookies Wafv2WebAclRuleA#cookies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchCookies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>header_order block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#header_order Wafv2WebAclRuleA#header_order}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaderOrder" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "headerOrder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeaderOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#headers Wafv2WebAclRuleA#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaders" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>ja3_fingerprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja3_fingerprint Wafv2WebAclRuleA#ja3_fingerprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa3Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ja3Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ja3Fingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>ja4_fingerprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja4_fingerprint Wafv2WebAclRuleA#ja4_fingerprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa4Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ja4Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ja4Fingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>json_body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#json_body Wafv2WebAclRuleA#json_body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJsonBody" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "jsonBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JsonBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#method Wafv2WebAclRuleA#method}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#query_string Wafv2WebAclRuleA#query_string}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_header Wafv2WebAclRuleA#single_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_query_argument Wafv2WebAclRuleA#single_query_argument}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_fragment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_fragment Wafv2WebAclRuleA#uri_fragment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriFragment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "uriFragment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UriFragment
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_path Wafv2WebAclRuleA#uri_path}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "uriPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#all_query_arguments Wafv2WebAclRuleA#all_query_arguments}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllQueryArguments
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#body Wafv2WebAclRuleA#body}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchBody" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Body
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#cookies Wafv2WebAclRuleA#cookies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchCookies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>header_order block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#header_order Wafv2WebAclRuleA#header_order}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaderOrder" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerOrder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HeaderOrder
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#headers Wafv2WebAclRuleA#headers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaders" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ja3_fingerprint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja3_fingerprint Wafv2WebAclRuleA#ja3_fingerprint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa3Fingerprint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ja3Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ja3Fingerprint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ja4_fingerprint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#ja4_fingerprint Wafv2WebAclRuleA#ja4_fingerprint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa4Fingerprint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ja4Fingerprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ja4Fingerprint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>json_body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#json_body Wafv2WebAclRuleA#json_body}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJsonBody" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JsonBody
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#method Wafv2WebAclRuleA#method}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Method
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#query_string Wafv2WebAclRuleA#query_string}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_header Wafv2WebAclRuleA#single_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SingleHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>single_query_argument block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#single_query_argument Wafv2WebAclRuleA#single_query_argument}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SingleQueryArgument
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>uri_fragment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_fragment Wafv2WebAclRuleA#uri_fragment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriFragment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriFragment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UriFragment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>uri_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#uri_path Wafv2WebAclRuleA#uri_path}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementSqliMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UriPath
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
