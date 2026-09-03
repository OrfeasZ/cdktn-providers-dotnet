using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit")]
    public class DatazonePolicyGrantPrincipalDomainUnit : aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_designation DatazonePolicyGrant#domain_unit_designation}.</summary>
        [JsiiProperty(name: "domainUnitDesignation", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainUnitDesignation
        {
            get;
            set;
        }

        private object? _allDomainUnitsGrantFilter;

        /// <summary>all_domain_units_grant_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_domain_units_grant_filter DatazonePolicyGrant#all_domain_units_grant_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allDomainUnitsGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllDomainUnitsGrantFilter
        {
            get => _allDomainUnitsGrantFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allDomainUnitsGrantFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_identifier DatazonePolicyGrant#domain_unit_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainUnitIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainUnitIdentifier
        {
            get;
            set;
        }
    }
}
