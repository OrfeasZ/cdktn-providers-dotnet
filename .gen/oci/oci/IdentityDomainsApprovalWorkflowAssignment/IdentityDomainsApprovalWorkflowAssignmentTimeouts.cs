using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflowAssignment
{
    [JsiiByValue(fqn: "oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeouts")]
    public class IdentityDomainsApprovalWorkflowAssignmentTimeouts : oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#create IdentityDomainsApprovalWorkflowAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#delete IdentityDomainsApprovalWorkflowAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#update IdentityDomainsApprovalWorkflowAssignment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
