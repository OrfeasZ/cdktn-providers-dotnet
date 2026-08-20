using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentProperties")]
    public class DynatraceMonitorEnvironmentProperties : azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties
    {
        private object _environmentInfo;

        /// <summary>environment_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/dynatrace_monitor#environment_info DynatraceMonitor#environment_info}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "environmentInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesEnvironmentInfo\"},\"kind\":\"array\"}}]}}")]
        public object EnvironmentInfo
        {
            get => _environmentInfo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentPropertiesEnvironmentInfo).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environmentInfo = value;
            }
        }
    }
}
