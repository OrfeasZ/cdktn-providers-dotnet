using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    [JsiiInterface(nativeType: typeof(IServiceendpointOpenshiftAuthBasic), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasic")]
    public interface IServiceendpointOpenshiftAuthBasic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#password ServiceendpointOpenshift#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#username ServiceendpointOpenshift#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointOpenshiftAuthBasic), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#password ServiceendpointOpenshift#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#username ServiceendpointOpenshift#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
