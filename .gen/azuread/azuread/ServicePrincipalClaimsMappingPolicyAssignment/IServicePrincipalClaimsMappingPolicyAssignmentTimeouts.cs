using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipalClaimsMappingPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalClaimsMappingPolicyAssignmentTimeouts), fullyQualifiedName: "azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentTimeouts")]
    public interface IServicePrincipalClaimsMappingPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#create ServicePrincipalClaimsMappingPolicyAssignment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#delete ServicePrincipalClaimsMappingPolicyAssignment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#read ServicePrincipalClaimsMappingPolicyAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalClaimsMappingPolicyAssignmentTimeouts), fullyQualifiedName: "azuread.servicePrincipalClaimsMappingPolicyAssignment.ServicePrincipalClaimsMappingPolicyAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipalClaimsMappingPolicyAssignment.IServicePrincipalClaimsMappingPolicyAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#create ServicePrincipalClaimsMappingPolicyAssignment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#delete ServicePrincipalClaimsMappingPolicyAssignment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_claims_mapping_policy_assignment#read ServicePrincipalClaimsMappingPolicyAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
