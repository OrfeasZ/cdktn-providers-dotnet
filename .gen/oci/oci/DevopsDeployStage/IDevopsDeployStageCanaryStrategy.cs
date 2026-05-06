using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageCanaryStrategy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageCanaryStrategy")]
    public interface IDevopsDeployStageCanaryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ingress_name DevopsDeployStage#ingress_name}.</summary>
        [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
        string IngressName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace DevopsDeployStage#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#strategy_type DevopsDeployStage#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        string StrategyType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageCanaryStrategy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageCanaryStrategy")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ingress_name DevopsDeployStage#ingress_name}.</summary>
            [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
            public string IngressName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace DevopsDeployStage#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#strategy_type DevopsDeployStage#strategy_type}.</summary>
            [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
            public string StrategyType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
