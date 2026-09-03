using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProject")]
    public class DatazonePolicyGrantPrincipalProject : aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_designation DatazonePolicyGrant#project_designation}.</summary>
        [JsiiProperty(name: "projectDesignation", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectDesignation
        {
            get;
            set;
        }

        private object? _domainUnitFilter;

        /// <summary>domain_unit_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_filter DatazonePolicyGrant#domain_unit_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProjectDomainUnitFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domainUnitFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProjectDomainUnitFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DomainUnitFilter
        {
            get => _domainUnitFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProjectDomainUnitFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProjectDomainUnitFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _domainUnitFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project_identifier DatazonePolicyGrant#project_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projectIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectIdentifier
        {
            get;
            set;
        }
    }
}
