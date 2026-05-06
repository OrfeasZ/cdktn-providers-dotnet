using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageGreenBackendIps), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageGreenBackendIps")]
    public interface IDevopsDeployStageGreenBackendIps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#items DevopsDeployStage#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageGreenBackendIps), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageGreenBackendIps")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageGreenBackendIps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#items DevopsDeployStage#items}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Items
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
