using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    [JsiiClass(nativeType: typeof(digitalocean.DropletAutoscale.DropletAutoscaleConfigAOutputReference), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DropletAutoscaleConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DropletAutoscaleConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DropletAutoscaleConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DropletAutoscaleConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCooldownMinutes")]
        public virtual void ResetCooldownMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxInstances")]
        public virtual void ResetMaxInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinInstances")]
        public virtual void ResetMinInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCpuUtilization")]
        public virtual void ResetTargetCpuUtilization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetMemoryUtilization")]
        public virtual void ResetTargetMemoryUtilization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetNumberInstances")]
        public virtual void ResetTargetNumberInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cooldownMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CooldownMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCpuUtilizationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetCpuUtilizationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryUtilizationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetMemoryUtilizationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNumberInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetNumberInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cooldownMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CooldownMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCpuUtilization", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCpuUtilization
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetMemoryUtilization", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetMemoryUtilization
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetNumberInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetNumberInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigA\"}", isOptional: true)]
        public virtual digitalocean.DropletAutoscale.IDropletAutoscaleConfigA? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.IDropletAutoscaleConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
