using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipal")]
    public class CloudwatchomniOrganizationAccessGrantPrincipal : aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_type CloudwatchomniOrganizationAccessGrant#principal_type}.</summary>
        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalType
        {
            get;
            set;
        }

        private object? _principalAttribute;

        /// <summary>principal_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_attribute CloudwatchomniOrganizationAccessGrant#principal_attribute}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principalAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principalAttribute = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_id CloudwatchomniOrganizationAccessGrant#principal_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrincipalId
        {
            get;
            set;
        }
    }
}
