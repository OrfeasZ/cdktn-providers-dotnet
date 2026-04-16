using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDropletAutoscale
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanDropletAutoscale.DataDigitaloceanDropletAutoscaleConfigAOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanDropletAutoscale.DataDigitaloceanDropletAutoscaleConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanDropletAutoscaleConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanDropletAutoscaleConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanDropletAutoscaleConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanDropletAutoscaleConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cooldownMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CooldownMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstances
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInstances
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetCpuUtilization", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCpuUtilization
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetMemoryUtilization", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetMemoryUtilization
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetNumberInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetNumberInstances
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanDropletAutoscale.DataDigitaloceanDropletAutoscaleConfigA\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanDropletAutoscale.IDataDigitaloceanDropletAutoscaleConfigA? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanDropletAutoscale.IDataDigitaloceanDropletAutoscaleConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
