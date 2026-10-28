using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResource")]
    public class CloudwatchomniAccessGrantScopedActionResource : aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#resource_type CloudwatchomniAccessGrant#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#resource_arns CloudwatchomniAccessGrant#resource_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceArns
        {
            get;
            set;
        }

        private object? _rowScopeGroup;

        /// <summary>row_scope_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#row_scope_group CloudwatchomniAccessGrant#row_scope_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rowScopeGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RowScopeGroup
        {
            get => _rowScopeGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rowScopeGroup = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#signal_types CloudwatchomniAccessGrant#signal_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signalTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SignalTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#tags CloudwatchomniAccessGrant#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
