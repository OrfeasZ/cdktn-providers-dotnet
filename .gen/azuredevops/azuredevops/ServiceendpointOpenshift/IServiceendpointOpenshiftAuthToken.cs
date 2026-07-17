using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    [JsiiInterface(nativeType: typeof(IServiceendpointOpenshiftAuthToken), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthToken")]
    public interface IServiceendpointOpenshiftAuthToken
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_openshift#token ServiceendpointOpenshift#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointOpenshiftAuthToken), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_openshift#token ServiceendpointOpenshift#token}.</summary>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
