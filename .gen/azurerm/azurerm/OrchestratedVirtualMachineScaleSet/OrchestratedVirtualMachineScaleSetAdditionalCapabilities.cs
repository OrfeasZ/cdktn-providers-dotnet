using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetAdditionalCapabilities")]
    public class OrchestratedVirtualMachineScaleSetAdditionalCapabilities : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetAdditionalCapabilities
    {
        private object? _ultraSsdEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/orchestrated_virtual_machine_scale_set#ultra_ssd_enabled OrchestratedVirtualMachineScaleSet#ultra_ssd_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UltraSsdEnabled
        {
            get => _ultraSsdEnabled;
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
                _ultraSsdEnabled = value;
            }
        }
    }
}
