using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageProductionLoadBalancerConfig")]
    public class DevopsDeployStageProductionLoadBalancerConfig : oci.DevopsDeployStage.IDevopsDeployStageProductionLoadBalancerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#backend_port DevopsDeployStage#backend_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackendPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#listener_name DevopsDeployStage#listener_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listenerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ListenerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#load_balancer_id DevopsDeployStage#load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancerId
        {
            get;
            set;
        }
    }
}
