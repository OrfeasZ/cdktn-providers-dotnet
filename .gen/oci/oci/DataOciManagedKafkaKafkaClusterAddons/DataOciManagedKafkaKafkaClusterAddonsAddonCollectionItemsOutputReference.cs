using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagedKafkaKafkaClusterAddons
{
    [JsiiClass(nativeType: typeof(oci.DataOciManagedKafkaKafkaClusterAddons.DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciManagedKafkaKafkaClusterAddons.DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addonType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddonType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkCidrs
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaClusterAddons.DataOciManagedKafkaKafkaClusterAddonsAddonCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciManagedKafkaKafkaClusterAddons.IDataOciManagedKafkaKafkaClusterAddonsAddonCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaClusterAddons.IDataOciManagedKafkaKafkaClusterAddonsAddonCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
