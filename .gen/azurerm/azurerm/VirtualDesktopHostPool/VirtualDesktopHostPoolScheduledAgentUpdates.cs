using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopHostPool
{
    [JsiiByValue(fqn: "azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdates")]
    public class VirtualDesktopHostPoolScheduledAgentUpdates : azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdates
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_host_pool#enabled VirtualDesktopHostPool#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        private object? _schedule;

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_host_pool#schedule VirtualDesktopHostPool#schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdatesSchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdatesSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schedule
        {
            get => _schedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdatesSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdatesSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_host_pool#timezone VirtualDesktopHostPool#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        private object? _useSessionHostTimezone;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_host_pool#use_session_host_timezone VirtualDesktopHostPool#use_session_host_timezone}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useSessionHostTimezone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseSessionHostTimezone
        {
            get => _useSessionHostTimezone;
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
                _useSessionHostTimezone = value;
            }
        }
    }
}
