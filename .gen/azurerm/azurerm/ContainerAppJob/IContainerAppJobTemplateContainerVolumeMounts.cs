using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobTemplateContainerVolumeMounts), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateContainerVolumeMounts")]
    public interface IContainerAppJobTemplateContainerVolumeMounts
    {
        /// <summary>The name of the Volume to be mounted in the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#name ContainerAppJob#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The path in the container at which to mount this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#path ContainerAppJob#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>The sub path of the volume to be mounted in the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#sub_path ContainerAppJob#sub_path}
        /// </remarks>
        [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobTemplateContainerVolumeMounts), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateContainerVolumeMounts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobTemplateContainerVolumeMounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the Volume to be mounted in the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#name ContainerAppJob#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The path in the container at which to mount this volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#path ContainerAppJob#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The sub path of the volume to be mounted in the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#sub_path ContainerAppJob#sub_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
