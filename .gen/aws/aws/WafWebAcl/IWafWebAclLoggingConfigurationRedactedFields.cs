using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafWebAcl
{
    [JsiiInterface(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFields")]
    public interface IWafWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/waf_web_acl#field_to_match WafWebAcl#field_to_match}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        object FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/waf_web_acl#field_to_match WafWebAcl#field_to_match}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
            public object FieldToMatch
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
