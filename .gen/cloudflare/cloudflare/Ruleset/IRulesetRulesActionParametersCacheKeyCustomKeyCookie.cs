using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyCookie), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyCookie
    {
        /// <summary>Checks for the presence of these cookie names.</summary>
        /// <remarks>
        /// The presence of these cookies is used in building the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#check_presence Ruleset#check_presence}
        /// </remarks>
        [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CheckPresence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include these cookies' names and their values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyCookie), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyCookie
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Checks for the presence of these cookie names.</summary>
            /// <remarks>
            /// The presence of these cookies is used in building the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#check_presence Ruleset#check_presence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckPresence
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Include these cookies' names and their values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Include
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
