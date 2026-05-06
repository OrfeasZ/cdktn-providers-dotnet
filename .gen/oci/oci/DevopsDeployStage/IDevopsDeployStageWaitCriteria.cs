using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageWaitCriteria), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageWaitCriteria")]
    public interface IDevopsDeployStageWaitCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_duration DevopsDeployStage#wait_duration}.</summary>
        [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
        string WaitDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_type DevopsDeployStage#wait_type}.</summary>
        [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
        string WaitType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageWaitCriteria), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageWaitCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageWaitCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_duration DevopsDeployStage#wait_duration}.</summary>
            [JsiiProperty(name: "waitDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string WaitDuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#wait_type DevopsDeployStage#wait_type}.</summary>
            [JsiiProperty(name: "waitType", typeJson: "{\"primitive\":\"string\"}")]
            public string WaitType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
