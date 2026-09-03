using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiByValue(fqn: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork")]
    public class MachineLearningWorkspaceManagedNetwork : azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/machine_learning_workspace#isolation_mode MachineLearningWorkspace#isolation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IsolationMode
        {
            get;
            set;
        }

        private object? _provisionOnCreationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/machine_learning_workspace#provision_on_creation_enabled MachineLearningWorkspace#provision_on_creation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionOnCreationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProvisionOnCreationEnabled
        {
            get => _provisionOnCreationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _provisionOnCreationEnabled = value;
            }
        }
    }
}
