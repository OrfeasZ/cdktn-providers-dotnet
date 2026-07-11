using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    [JsiiInterface(nativeType: typeof(IServiceendpointOpenshiftAuthNone), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone")]
    public interface IServiceendpointOpenshiftAuthNone
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#kube_config ServiceendpointOpenshift#kube_config}.</summary>
        [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KubeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointOpenshiftAuthNone), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#kube_config ServiceendpointOpenshift#kube_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KubeConfig
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
