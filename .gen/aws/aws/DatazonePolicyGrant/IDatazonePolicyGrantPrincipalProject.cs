using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantPrincipalProject), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProject")]
    public interface IDatazonePolicyGrantPrincipalProject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_designation DatazonePolicyGrant#project_designation}.</summary>
        [JsiiProperty(name: "projectDesignation", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectDesignation
        {
            get;
        }

        /// <summary>domain_unit_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_filter DatazonePolicyGrant#domain_unit_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProjectDomainUnitFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "domainUnitFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProjectDomainUnitFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DomainUnitFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_identifier DatazonePolicyGrant#project_identifier}.</summary>
        [JsiiProperty(name: "projectIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantPrincipalProject), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProject")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProject
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_designation DatazonePolicyGrant#project_designation}.</summary>
            [JsiiProperty(name: "projectDesignation", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectDesignation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>domain_unit_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_filter DatazonePolicyGrant#domain_unit_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProjectDomainUnitFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainUnitFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProjectDomainUnitFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DomainUnitFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_identifier DatazonePolicyGrant#project_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "projectIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
