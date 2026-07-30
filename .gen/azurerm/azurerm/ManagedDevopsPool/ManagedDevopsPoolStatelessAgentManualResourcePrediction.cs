using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction")]
    public class ManagedDevopsPoolStatelessAgentManualResourcePrediction : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#all_week_schedule ManagedDevopsPool#all_week_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllWeekSchedule
        {
            get;
            set;
        }

        private object? _fridaySchedule;

        /// <summary>friday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#friday_schedule ManagedDevopsPool#friday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FridaySchedule
        {
            get => _fridaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fridaySchedule = value;
            }
        }

        private object? _mondaySchedule;

        /// <summary>monday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#monday_schedule ManagedDevopsPool#monday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MondaySchedule
        {
            get => _mondaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mondaySchedule = value;
            }
        }

        private object? _saturdaySchedule;

        /// <summary>saturday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#saturday_schedule ManagedDevopsPool#saturday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SaturdaySchedule
        {
            get => _saturdaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _saturdaySchedule = value;
            }
        }

        private object? _sundaySchedule;

        /// <summary>sunday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#sunday_schedule ManagedDevopsPool#sunday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SundaySchedule
        {
            get => _sundaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sundaySchedule = value;
            }
        }

        private object? _thursdaySchedule;

        /// <summary>thursday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#thursday_schedule ManagedDevopsPool#thursday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThursdaySchedule
        {
            get => _thursdaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _thursdaySchedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#time_zone_name ManagedDevopsPool#time_zone_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZoneName
        {
            get;
            set;
        }

        private object? _tuesdaySchedule;

        /// <summary>tuesday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#tuesday_schedule ManagedDevopsPool#tuesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TuesdaySchedule
        {
            get => _tuesdaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tuesdaySchedule = value;
            }
        }

        private object? _wednesdaySchedule;

        /// <summary>wednesday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#wednesday_schedule ManagedDevopsPool#wednesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WednesdaySchedule
        {
            get => _wednesdaySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _wednesdaySchedule = value;
            }
        }
    }
}
