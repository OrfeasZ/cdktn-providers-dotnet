using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup), fullyQualifiedName: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroup")]
    public interface ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup
    {
        /// <summary>row_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#row_scope CloudwatchomniAccessGrant#row_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rowScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RowScope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup), fullyQualifiedName: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroup")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>row_scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#row_scope CloudwatchomniAccessGrant#row_scope}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rowScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RowScope
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
