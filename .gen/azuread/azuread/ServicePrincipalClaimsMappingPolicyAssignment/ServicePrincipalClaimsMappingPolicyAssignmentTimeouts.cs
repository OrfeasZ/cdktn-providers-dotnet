using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipalClaimsMappingPolicyAssignment
{
    [JsiiByValue(fqn: "azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentTimeouts")]
    public class ServicePrincipalClaimsMappingPolicyAssignmentTimeouts : azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#create ServicePrincipalClaimsMappingPolicyAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#delete ServicePrincipalClaimsMappingPolicyAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#read ServicePrincipalClaimsMappingPolicyAssignment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
