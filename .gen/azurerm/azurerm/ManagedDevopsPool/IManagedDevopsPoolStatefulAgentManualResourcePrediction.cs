using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatefulAgentManualResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction")]
    public interface IManagedDevopsPoolStatefulAgentManualResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#all_week_schedule ManagedDevopsPool#all_week_schedule}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#friday_schedule ManagedDevopsPool#friday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#monday_schedule ManagedDevopsPool#monday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#saturday_schedule ManagedDevopsPool#saturday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#sunday_schedule ManagedDevopsPool#sunday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#thursday_schedule ManagedDevopsPool#thursday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThursdaySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#time_zone_name ManagedDevopsPool#time_zone_name}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#tuesday_schedule ManagedDevopsPool#tuesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#wednesday_schedule ManagedDevopsPool#wednesday_schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WednesdaySchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatefulAgentManualResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#all_week_schedule ManagedDevopsPool#all_week_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllWeekSchedule
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>friday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#friday_schedule ManagedDevopsPool#friday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fridaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FridaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#monday_schedule ManagedDevopsPool#monday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mondaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MondaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>saturday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#saturday_schedule ManagedDevopsPool#saturday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SaturdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sunday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#sunday_schedule ManagedDevopsPool#sunday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sundaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SundaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>thursday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#thursday_schedule ManagedDevopsPool#thursday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThursdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#time_zone_name ManagedDevopsPool#time_zone_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZoneName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tuesday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#tuesday_schedule ManagedDevopsPool#tuesday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TuesdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>wednesday_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#wednesday_schedule ManagedDevopsPool#wednesday_schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WednesdaySchedule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
