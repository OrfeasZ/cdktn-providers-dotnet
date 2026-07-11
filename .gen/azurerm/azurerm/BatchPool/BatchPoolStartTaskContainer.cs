using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolStartTaskContainer")]
    public class BatchPoolStartTaskContainer : azurerm.BatchPool.IBatchPoolStartTaskContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#image_name BatchPool#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageName
        {
            get;
            set;
        }

        private object? _registry;

        /// <summary>registry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#registry BatchPool#registry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolStartTaskContainerRegistry" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainerRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Registry
        {
            get => _registry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolStartTaskContainerRegistry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolStartTaskContainerRegistry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _registry = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#run_options BatchPool#run_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RunOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/batch_pool#working_directory BatchPool#working_directory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkingDirectory
        {
            get;
            set;
        }
    }
}
