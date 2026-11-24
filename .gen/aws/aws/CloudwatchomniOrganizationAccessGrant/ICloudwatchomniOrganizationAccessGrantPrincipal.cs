using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationAccessGrant
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniOrganizationAccessGrantPrincipal), fullyQualifiedName: "aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipal")]
    public interface ICloudwatchomniOrganizationAccessGrantPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_type CloudwatchomniOrganizationAccessGrant#principal_type}.</summary>
        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalType
        {
            get;
        }

        /// <summary>principal_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_attribute CloudwatchomniOrganizationAccessGrant#principal_attribute}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "principalAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrincipalAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_id CloudwatchomniOrganizationAccessGrant#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrincipalId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniOrganizationAccessGrantPrincipal), fullyQualifiedName: "aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_type CloudwatchomniOrganizationAccessGrant#principal_type}.</summary>
            [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>principal_attribute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_attribute CloudwatchomniOrganizationAccessGrant#principal_attribute}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principalAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrincipalAttribute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#principal_id CloudwatchomniOrganizationAccessGrant#principal_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrincipalId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
