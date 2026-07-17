using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointVisualstudiomarketplace
{
    [JsiiInterface(nativeType: typeof(IServiceendpointVisualstudiomarketplaceAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointVisualstudiomarketplace.ServiceendpointVisualstudiomarketplaceAuthenticationBasic")]
    public interface IServiceendpointVisualstudiomarketplaceAuthenticationBasic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#password ServiceendpointVisualstudiomarketplace#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#username ServiceendpointVisualstudiomarketplace#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointVisualstudiomarketplaceAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointVisualstudiomarketplace.ServiceendpointVisualstudiomarketplaceAuthenticationBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointVisualstudiomarketplace.IServiceendpointVisualstudiomarketplaceAuthenticationBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#password ServiceendpointVisualstudiomarketplace#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#username ServiceendpointVisualstudiomarketplace#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
