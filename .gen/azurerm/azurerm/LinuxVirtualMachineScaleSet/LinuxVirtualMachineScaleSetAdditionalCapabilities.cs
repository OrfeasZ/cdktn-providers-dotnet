using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachineScaleSet
{
    [JsiiByValue(fqn: "azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities")]
    public class LinuxVirtualMachineScaleSetAdditionalCapabilities : azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities
    {
        private object? _ultraSsdEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#ultra_ssd_enabled LinuxVirtualMachineScaleSet#ultra_ssd_enabled}.</summary>
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
