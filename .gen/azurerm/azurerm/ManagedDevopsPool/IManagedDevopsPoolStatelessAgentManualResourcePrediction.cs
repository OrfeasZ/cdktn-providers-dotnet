using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatelessAgentManualResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction")]
    public interface IManagedDevopsPoolStatelessAgentManualResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#all_week_schedule ManagedDevopsPool#all_week_schedule}.</summary>
        [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllWeekSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>friday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#friday_schedule ManagedDevopsPool#friday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FridaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>monday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#monday_schedule ManagedDevopsPool#monday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MondaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>saturday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#saturday_schedule ManagedDevopsPool#saturday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SaturdaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>sunday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#sunday_schedule ManagedDevopsPool#sunday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SundaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>thursday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#thursday_schedule ManagedDevopsPool#thursday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThursdaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#time_zone_name ManagedDevopsPool#time_zone_name}.</summary>
        [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZoneName
        {
            get
            {
                return null;
            }
        }

        /// <summary>tuesday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#tuesday_schedule ManagedDevopsPool#tuesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TuesdaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>wednesday_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#wednesday_schedule ManagedDevopsPool#wednesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WednesdaySchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatelessAgentManualResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#all_week_schedule ManagedDevopsPool#all_week_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllWeekSchedule
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>friday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#friday_schedule ManagedDevopsPool#friday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fridaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FridaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#monday_schedule ManagedDevopsPool#monday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mondaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MondaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>saturday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#saturday_schedule ManagedDevopsPool#saturday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SaturdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sunday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#sunday_schedule ManagedDevopsPool#sunday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sundaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SundaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>thursday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#thursday_schedule ManagedDevopsPool#thursday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThursdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#time_zone_name ManagedDevopsPool#time_zone_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZoneName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tuesday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#tuesday_schedule ManagedDevopsPool#tuesday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TuesdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>wednesday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#wednesday_schedule ManagedDevopsPool#wednesday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WednesdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
