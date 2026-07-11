using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointVisualstudiomarketplace
{
    [JsiiInterface(nativeType: typeof(IServiceendpointVisualstudiomarketplaceAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointVisualstudiomarketplace.ServiceendpointVisualstudiomarketplaceAuthenticationToken")]
    public interface IServiceendpointVisualstudiomarketplaceAuthenticationToken
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_visualstudiomarketplace#token ServiceendpointVisualstudiomarketplace#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointVisualstudiomarketplaceAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointVisualstudiomarketplace.ServiceendpointVisualstudiomarketplaceAuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointVisualstudiomarketplace.IServiceendpointVisualstudiomarketplaceAuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_visualstudiomarketplace#token ServiceendpointVisualstudiomarketplace#token}.</summary>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
