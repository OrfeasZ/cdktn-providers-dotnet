using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageCanaryStrategy")]
    public class DevopsDeployStageCanaryStrategy : oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ingress_name DevopsDeployStage#ingress_name}.</summary>
        [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
        public string IngressName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace DevopsDeployStage#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#strategy_type DevopsDeployStage#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        public string StrategyType
        {
            get;
            set;
        }
    }
}
