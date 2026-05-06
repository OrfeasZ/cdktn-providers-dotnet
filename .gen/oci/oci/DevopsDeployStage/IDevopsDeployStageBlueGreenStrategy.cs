using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageBlueGreenStrategy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy")]
    public interface IDevopsDeployStageBlueGreenStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#ingress_name DevopsDeployStage#ingress_name}.</summary>
        [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
        string IngressName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_a DevopsDeployStage#namespace_a}.</summary>
        [JsiiProperty(name: "namespaceA", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceA
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_b DevopsDeployStage#namespace_b}.</summary>
        [JsiiProperty(name: "namespaceB", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceB
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#strategy_type DevopsDeployStage#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        string StrategyType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageBlueGreenStrategy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageBlueGreenStrategy")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageBlueGreenStrategy
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_a DevopsDeployStage#namespace_a}.</summary>
            [JsiiProperty(name: "namespaceA", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceA
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#namespace_b DevopsDeployStage#namespace_b}.</summary>
            [JsiiProperty(name: "namespaceB", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceB
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
