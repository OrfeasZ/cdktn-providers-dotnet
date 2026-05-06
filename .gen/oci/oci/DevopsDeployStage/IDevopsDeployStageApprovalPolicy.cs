using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageApprovalPolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageApprovalPolicy")]
    public interface IDevopsDeployStageApprovalPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#approval_policy_type DevopsDeployStage#approval_policy_type}.</summary>
        [JsiiProperty(name: "approvalPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        string ApprovalPolicyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#number_of_approvals_required DevopsDeployStage#number_of_approvals_required}.</summary>
        [JsiiProperty(name: "numberOfApprovalsRequired", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfApprovalsRequired
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageApprovalPolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageApprovalPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageApprovalPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#approval_policy_type DevopsDeployStage#approval_policy_type}.</summary>
            [JsiiProperty(name: "approvalPolicyType", typeJson: "{\"primitive\":\"string\"}")]
            public string ApprovalPolicyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#number_of_approvals_required DevopsDeployStage#number_of_approvals_required}.</summary>
            [JsiiProperty(name: "numberOfApprovalsRequired", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfApprovalsRequired
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
