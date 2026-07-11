using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiInterface(nativeType: typeof(IContainerGroupContainerSecurity), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupContainerSecurity")]
    public interface IContainerGroupContainerSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_group#privilege_enabled ContainerGroup#privilege_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "privilegeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object PrivilegeEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerGroupContainerSecurity), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupContainerSecurity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerGroup.IContainerGroupContainerSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_group#privilege_enabled ContainerGroup#privilege_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "privilegeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object PrivilegeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
