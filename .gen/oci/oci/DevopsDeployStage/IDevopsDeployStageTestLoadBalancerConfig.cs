using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageTestLoadBalancerConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig")]
    public interface IDevopsDeployStageTestLoadBalancerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#backend_port DevopsDeployStage#backend_port}.</summary>
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#listener_name DevopsDeployStage#listener_name}.</summary>
        [JsiiProperty(name: "listenerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ListenerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#load_balancer_id DevopsDeployStage#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageTestLoadBalancerConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageTestLoadBalancerConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageTestLoadBalancerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#backend_port DevopsDeployStage#backend_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#listener_name DevopsDeployStage#listener_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ListenerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#load_balancer_id DevopsDeployStage#load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
