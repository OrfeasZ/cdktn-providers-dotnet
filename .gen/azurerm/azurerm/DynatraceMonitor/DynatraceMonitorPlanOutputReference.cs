using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiClass(nativeType: typeof(azurerm.DynatraceMonitor.DynatraceMonitorPlanOutputReference), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynatraceMonitorPlanOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynatraceMonitorPlanOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceMonitorPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceMonitorPlanOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBillingCycle")]
        public virtual void ResetBillingCycle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageType")]
        public virtual void ResetUsageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EffectiveDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingCycleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingCycleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingCycle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorPlan\"}", isOptional: true)]
        public virtual azurerm.DynatraceMonitor.IDynatraceMonitorPlan? InternalValue
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.IDynatraceMonitorPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
