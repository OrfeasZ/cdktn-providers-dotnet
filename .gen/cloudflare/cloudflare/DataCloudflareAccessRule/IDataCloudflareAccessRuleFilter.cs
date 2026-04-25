using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccessRule
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAccessRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareAccessRule.DataCloudflareAccessRuleFilter")]
    public interface IDataCloudflareAccessRuleFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#configuration DataCloudflareAccessRule#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccessRule.DataCloudflareAccessRuleFilterConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareAccessRule.IDataCloudflareAccessRuleFilterConfiguration? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the direction used to sort returned rules. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#direction DataCloudflareAccessRule#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the search requirements.</summary>
        /// <remarks>
        /// When set to <c>all</c>, all the search requirements must match. When set to <c>any</c>, only one of the search requirements has to match.
        /// Available values: "any", "all".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#match DataCloudflareAccessRule#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>The action to apply to a matched request. Available values: "block", "challenge", "whitelist", "js_challenge", "managed_challenge".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#mode DataCloudflareAccessRule#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the string to search for in the notes of existing IP Access rules.</summary>
        /// <remarks>
        /// Notes: For example, the string 'attack' would match IP Access rules with notes 'Attack 26/02' and 'Attack 27/02'. The search is case insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#notes DataCloudflareAccessRule#notes}
        /// </remarks>
        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Notes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the field used to sort returned rules. Available values: "configuration.target", "configuration.value", "mode".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#order DataCloudflareAccessRule#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAccessRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareAccessRule.DataCloudflareAccessRuleFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAccessRule.IDataCloudflareAccessRuleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#configuration DataCloudflareAccessRule#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccessRule.DataCloudflareAccessRuleFilterConfiguration\"}", isOptional: true)]
            public cloudflare.DataCloudflareAccessRule.IDataCloudflareAccessRuleFilterConfiguration? Configuration
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareAccessRule.IDataCloudflareAccessRuleFilterConfiguration?>();
            }

            /// <summary>Defines the direction used to sort returned rules. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#direction DataCloudflareAccessRule#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the search requirements.</summary>
            /// <remarks>
            /// When set to <c>all</c>, all the search requirements must match. When set to <c>any</c>, only one of the search requirements has to match.
            /// Available values: "any", "all".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#match DataCloudflareAccessRule#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Match
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The action to apply to a matched request. Available values: "block", "challenge", "whitelist", "js_challenge", "managed_challenge".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#mode DataCloudflareAccessRule#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the string to search for in the notes of existing IP Access rules.</summary>
            /// <remarks>
            /// Notes: For example, the string 'attack' would match IP Access rules with notes 'Attack 26/02' and 'Attack 27/02'. The search is case insensitive.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#notes DataCloudflareAccessRule#notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Notes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the field used to sort returned rules. Available values: "configuration.target", "configuration.value", "mode".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/access_rule#order DataCloudflareAccessRule#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
