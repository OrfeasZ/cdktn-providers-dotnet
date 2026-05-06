using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflowAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow")]
    public class IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow : oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#type IdentityDomainsApprovalWorkflowAssignment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#value IdentityDomainsApprovalWorkflowAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#ocid IdentityDomainsApprovalWorkflowAssignment#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }
    }
}
