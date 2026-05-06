using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflowStep
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApprovalWorkflowStep.IdentityDomainsApprovalWorkflowStepApprovers")]
    public class IdentityDomainsApprovalWorkflowStepApprovers : oci.IdentityDomainsApprovalWorkflowStep.IIdentityDomainsApprovalWorkflowStepApprovers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_step#type IdentityDomainsApprovalWorkflowStep#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_step#value IdentityDomainsApprovalWorkflowStep#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_step#ocid IdentityDomainsApprovalWorkflowStep#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }
    }
}
