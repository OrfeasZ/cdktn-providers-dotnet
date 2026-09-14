using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayKafkaVersion
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsOutputReference), fullyQualifiedName: "scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayKafkaVersionAvailableSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayKafkaVersionAvailableSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayKafkaVersionAvailableSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayKafkaVersionAvailableSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "boolProperty", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsBoolPropertyOutputReference\"}")]
        public virtual scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsBoolPropertyOutputReference BoolProperty
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsBoolPropertyOutputReference>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "floatProperty", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference\"}")]
        public virtual scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference FloatProperty
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsFloatPropertyOutputReference>()!;
        }

        [JsiiProperty(name: "hotConfigurable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HotConfigurable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "intProperty", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsIntPropertyOutputReference\"}")]
        public virtual scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsIntPropertyOutputReference IntProperty
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsIntPropertyOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stringProperty", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference\"}")]
        public virtual scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference StringProperty
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettingsStringPropertyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayKafkaVersion.DataScalewayKafkaVersionAvailableSettings\"}", isOptional: true)]
        public virtual scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettings? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayKafkaVersion.IDataScalewayKafkaVersionAvailableSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
