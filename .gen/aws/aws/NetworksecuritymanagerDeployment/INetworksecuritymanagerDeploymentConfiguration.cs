using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerDeployment
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerDeploymentConfiguration), fullyQualifiedName: "aws.networksecuritymanagerDeployment.NetworksecuritymanagerDeploymentConfiguration")]
    public interface INetworksecuritymanagerDeploymentConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_deployment#enable_cross_account_visibility NetworksecuritymanagerDeployment#enable_cross_account_visibility}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableCrossAccountVisibility", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableCrossAccountVisibility
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerDeploymentConfiguration), fullyQualifiedName: "aws.networksecuritymanagerDeployment.NetworksecuritymanagerDeploymentConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerDeployment.INetworksecuritymanagerDeploymentConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_deployment#enable_cross_account_visibility NetworksecuritymanagerDeployment#enable_cross_account_visibility}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enableCrossAccountVisibility", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableCrossAccountVisibility
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
