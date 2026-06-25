using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CostadCostAnomalyMonitor
{
    [JsiiClass(nativeType: typeof(oci.CostadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference), fullyQualifiedName: "oci.costadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CostadCostAnomalyMonitorCostAlertSubscriptionMapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCostAlertSubscriptionId")]
        public virtual void ResetCostAlertSubscriptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperator")]
        public virtual void ResetOperator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThresholdAbsoluteValue")]
        public virtual void ResetThresholdAbsoluteValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThresholdRelativePercent")]
        public virtual void ResetThresholdRelativePercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "costAlertSubscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CostAlertSubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdAbsoluteValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdAbsoluteValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdRelativePercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdRelativePercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAlertSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThresholdAbsoluteValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThresholdRelativePercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.costadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMap\"}", isOptional: true)]
        public virtual oci.CostadCostAnomalyMonitor.ICostadCostAnomalyMonitorCostAlertSubscriptionMap? InternalValue
        {
            get => GetInstanceProperty<oci.CostadCostAnomalyMonitor.ICostadCostAnomalyMonitorCostAlertSubscriptionMap?>();
            set => SetInstanceProperty(value);
        }
    }
}
