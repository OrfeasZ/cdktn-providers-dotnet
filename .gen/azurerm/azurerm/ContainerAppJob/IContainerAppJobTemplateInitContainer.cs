using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobTemplateInitContainer), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateInitContainer")]
    public interface IContainerAppJobTemplateInitContainer
    {
        /// <summary>The image to use to create the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#image ContainerAppJob#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>The name of the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#name ContainerAppJob#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>A list of args to pass to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#args ContainerAppJob#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>A command to pass to the container to override the default.</summary>
        /// <remarks>
        /// This is provided as a list of command line elements without spaces.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#command ContainerAppJob#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of vCPU to allocate to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#cpu ContainerAppJob#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#env ContainerAppJob#env}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateInitContainerEnv" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateInitContainerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of memory to allocate to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#memory ContainerAppJob#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume_mounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#volume_mounts ContainerAppJob#volume_mounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateInitContainerVolumeMounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "volumeMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateInitContainerVolumeMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VolumeMounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobTemplateInitContainer), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateInitContainer")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobTemplateInitContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The image to use to create the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#image ContainerAppJob#image}
            /// </remarks>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#name ContainerAppJob#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A list of args to pass to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#args ContainerAppJob#args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A command to pass to the container to override the default.</summary>
            /// <remarks>
            /// This is provided as a list of command line elements without spaces.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#command ContainerAppJob#command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Command
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The amount of vCPU to allocate to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#cpu ContainerAppJob#cpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cpu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#env ContainerAppJob#env}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateInitContainerEnv" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateInitContainerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The amount of memory to allocate to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#memory ContainerAppJob#memory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volume_mounts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app_job#volume_mounts ContainerAppJob#volume_mounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateInitContainerVolumeMounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateInitContainerVolumeMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VolumeMounts
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
