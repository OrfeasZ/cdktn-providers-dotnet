using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy")]
    public class DevopsDeployStageBlueGreenStrategy : oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ingress_name DevopsDeployStage#ingress_name}.</summary>
        [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
        public string IngressName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_a DevopsDeployStage#namespace_a}.</summary>
        [JsiiProperty(name: "namespaceA", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceA
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_b DevopsDeployStage#namespace_b}.</summary>
        [JsiiProperty(name: "namespaceB", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceB
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
