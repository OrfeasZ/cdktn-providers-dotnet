using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflowAssignment
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow), fullyQualifiedName: "oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow")]
    public interface IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#type IdentityDomainsApprovalWorkflowAssignment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#value IdentityDomainsApprovalWorkflowAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#ocid IdentityDomainsApprovalWorkflowAssignment#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow), fullyQualifiedName: "oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#type IdentityDomainsApprovalWorkflowAssignment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#value IdentityDomainsApprovalWorkflowAssignment#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#ocid IdentityDomainsApprovalWorkflowAssignment#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
