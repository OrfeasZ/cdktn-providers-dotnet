using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Droplet
{
    [JsiiClass(nativeType: typeof(digitalocean.Droplet.DropletBackupPolicyOutputReference), fullyQualifiedName: "digitalocean.droplet.DropletBackupPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DropletBackupPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DropletBackupPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DropletBackupPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DropletBackupPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHour")]
        public virtual void ResetHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeekday")]
        public virtual void ResetWeekday()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weekdayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeekdayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Weekday
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.droplet.DropletBackupPolicy\"}", isOptional: true)]
        public virtual digitalocean.Droplet.IDropletBackupPolicy? InternalValue
        {
            get => GetInstanceProperty<digitalocean.Droplet.IDropletBackupPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
