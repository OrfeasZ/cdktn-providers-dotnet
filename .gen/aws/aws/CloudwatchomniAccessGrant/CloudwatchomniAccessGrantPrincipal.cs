using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantPrincipal")]
    public class CloudwatchomniAccessGrantPrincipal : aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#principal_type CloudwatchomniAccessGrant#principal_type}.</summary>
        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalType
        {
            get;
            set;
        }

        private object? _principalAttribute;

        /// <summary>principal_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#principal_attribute CloudwatchomniAccessGrant#principal_attribute}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantPrincipalPrincipalAttribute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principalAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantPrincipalPrincipalAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrincipalAttribute
        {
            get => _principalAttribute;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantPrincipalPrincipalAttribute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantPrincipalPrincipalAttribute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principalAttribute = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#principal_id CloudwatchomniAccessGrant#principal_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrincipalId
        {
            get;
            set;
        }
    }
}
