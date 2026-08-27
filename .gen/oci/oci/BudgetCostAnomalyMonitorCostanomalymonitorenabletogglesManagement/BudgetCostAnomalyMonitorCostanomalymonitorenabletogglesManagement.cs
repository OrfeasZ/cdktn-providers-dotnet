using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management oci_budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement), fullyQualifiedName: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig\"}}]")]
    public class BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management oci_budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement(Constructs.Construct scope, string id, oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement to import.</param>
        /// <param name="importFromId">The id of the existing BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeoutsOutputReference\"}")]
        public virtual oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costAnomalyMonitorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CostAnomalyMonitorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableCostanomalymonitorenabletoggleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableCostanomalymonitorenabletoggleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "costAnomalyMonitorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAnomalyMonitorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableCostanomalymonitorenabletoggle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableCostanomalymonitorenabletoggle
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
