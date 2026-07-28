using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolStartTask), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTask")]
    public interface IBatchPoolStartTask
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#command_line BatchPool#command_line}.</summary>
        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}")]
        string CommandLine
        {
            get;
        }

        /// <summary>user_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#user_identity BatchPool#user_identity}
        /// </remarks>
        [JsiiProperty(name: "userIdentity", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentity\"}")]
        azurerm.BatchPool.IBatchPoolStartTaskUserIdentity UserIdentity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#common_environment_properties BatchPool#common_environment_properties}.</summary>
        [JsiiProperty(name: "commonEnvironmentProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CommonEnvironmentProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#container BatchPool#container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolStartTaskContainer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Container
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#resource_file BatchPool#resource_file}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolStartTaskResourceFile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskResourceFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#task_retry_maximum BatchPool#task_retry_maximum}.</summary>
        [JsiiProperty(name: "taskRetryMaximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskRetryMaximum
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#wait_for_success BatchPool#wait_for_success}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "waitForSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WaitForSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolStartTask), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTask")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolStartTask
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#command_line BatchPool#command_line}.</summary>
            [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}")]
            public string CommandLine
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>user_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#user_identity BatchPool#user_identity}
            /// </remarks>
            [JsiiProperty(name: "userIdentity", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentity\"}")]
            public azurerm.BatchPool.IBatchPoolStartTaskUserIdentity UserIdentity
            {
                get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTaskUserIdentity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#common_environment_properties BatchPool#common_environment_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonEnvironmentProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CommonEnvironmentProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#container BatchPool#container}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolStartTaskContainer" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Container
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#resource_file BatchPool#resource_file}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolStartTaskResourceFile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskResourceFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#task_retry_maximum BatchPool#task_retry_maximum}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskRetryMaximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskRetryMaximum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/batch_pool#wait_for_success BatchPool#wait_for_success}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "waitForSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WaitForSuccess
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
