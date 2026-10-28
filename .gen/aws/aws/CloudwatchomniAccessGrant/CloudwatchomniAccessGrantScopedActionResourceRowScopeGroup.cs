using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    [JsiiByValue(fqn: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroup")]
    public class CloudwatchomniAccessGrantScopedActionResourceRowScopeGroup : aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup
    {
        private object? _rowScope;

        /// <summary>row_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#row_scope CloudwatchomniAccessGrant#row_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rowScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RowScope
        {
            get => _rowScope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rowScope = value;
            }
        }
    }
}
