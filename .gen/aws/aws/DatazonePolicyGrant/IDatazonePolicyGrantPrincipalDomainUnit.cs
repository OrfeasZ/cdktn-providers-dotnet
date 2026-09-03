using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantPrincipalDomainUnit), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit")]
    public interface IDatazonePolicyGrantPrincipalDomainUnit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_designation DatazonePolicyGrant#domain_unit_designation}.</summary>
        [JsiiProperty(name: "domainUnitDesignation", typeJson: "{\"primitive\":\"string\"}")]
        string DomainUnitDesignation
        {
            get;
        }

        /// <summary>all_domain_units_grant_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_domain_units_grant_filter DatazonePolicyGrant#all_domain_units_grant_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "allDomainUnitsGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllDomainUnitsGrantFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_identifier DatazonePolicyGrant#domain_unit_identifier}.</summary>
        [JsiiProperty(name: "domainUnitIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainUnitIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantPrincipalDomainUnit), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_designation DatazonePolicyGrant#domain_unit_designation}.</summary>
            [JsiiProperty(name: "domainUnitDesignation", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainUnitDesignation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>all_domain_units_grant_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_domain_units_grant_filter DatazonePolicyGrant#all_domain_units_grant_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allDomainUnitsGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllDomainUnitsGrantFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_identifier DatazonePolicyGrant#domain_unit_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainUnitIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainUnitIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
