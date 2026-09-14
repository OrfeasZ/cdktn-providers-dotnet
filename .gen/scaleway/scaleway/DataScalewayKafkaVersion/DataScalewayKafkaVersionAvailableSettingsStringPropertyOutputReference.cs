using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayKafkaVersion
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference), fullyQualifiedName: "scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stringConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StringConstraint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringProperty\"}", isOptional: true)]
        public virtual scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettingsStringProperty? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettingsStringProperty?>();
            set => SetInstanceProperty(value);
        }
    }
}
