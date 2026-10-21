using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteria")]
    public class ZeroTrustAccessApplicationTargetCriteria : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteria
    {
        /// <summary>The port that the targets use for the chosen communication protocol. A port cannot be assigned to multiple protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#port ZeroTrustAccessApplication#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>The communication protocol your application secures. Available values: "SSH", "RDP".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#protocol ZeroTrustAccessApplication#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Target is excluded when any selector in this rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#exclude ZeroTrustAccessApplication#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaExclude\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaExclude? Exclude
        {
            get;
            set;
        }

        /// <summary>Target matches when any selector in this rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#include ZeroTrustAccessApplication#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaInclude\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaInclude? Include
        {
            get;
            set;
        }

        /// <summary>Target matches only when every selector in this rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#require ZeroTrustAccessApplication#require}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "require", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaRequire\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaRequire? Require
        {
            get;
            set;
        }

        private object? _targetAttributes;

        /// <summary>Deprecated: use include.target_attributes for hostname selectors and rule tags for tag-based matching. New or changed maps may contain only hostname. The API accepts unchanged legacy maps on update, including non-hostname keys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#target_attributes ZeroTrustAccessApplication#target_attributes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? TargetAttributes
        {
            get => _targetAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetAttributes = value;
            }
        }
    }
}
