using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflow
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsApprovalWorkflowTags), fullyQualifiedName: "oci.identityDomainsApprovalWorkflow.IdentityDomainsApprovalWorkflowTags")]
    public interface IIdentityDomainsApprovalWorkflowTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow#key IdentityDomainsApprovalWorkflow#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow#value IdentityDomainsApprovalWorkflow#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsApprovalWorkflowTags), fullyQualifiedName: "oci.identityDomainsApprovalWorkflow.IdentityDomainsApprovalWorkflowTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApprovalWorkflow.IIdentityDomainsApprovalWorkflowTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow#key IdentityDomainsApprovalWorkflow#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow#value IdentityDomainsApprovalWorkflow#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
