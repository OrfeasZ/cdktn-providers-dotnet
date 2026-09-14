using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayKafkaVersion
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference), fullyQualifiedName: "scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Max
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Min
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Unit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatProperty\"}", isOptional: true)]
        public virtual scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettingsFloatProperty? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettingsFloatProperty?>();
            set => SetInstanceProperty(value);
        }
    }
}
