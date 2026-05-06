using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageRollbackPolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageRollbackPolicy")]
    public interface IDevopsDeployStageRollbackPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageRollbackPolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageRollbackPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageRollbackPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
