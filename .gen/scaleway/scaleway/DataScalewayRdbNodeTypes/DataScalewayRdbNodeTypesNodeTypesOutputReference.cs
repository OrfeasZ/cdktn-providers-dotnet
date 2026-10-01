using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayRdbNodeTypes
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypesOutputReference), fullyQualifiedName: "scaleway.dataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayRdbNodeTypesNodeTypesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayRdbNodeTypesNodeTypesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayRdbNodeTypesNodeTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayRdbNodeTypesNodeTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableVolumeTypes", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypesAvailableVolumeTypesList\"}")]
        public virtual scaleway.DataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypesAvailableVolumeTypesList AvailableVolumeTypes
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypesAvailableVolumeTypesList>()!;
        }

        [JsiiProperty(name: "beta", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Beta
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Disabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Generation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceRange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceRange
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHaRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHaRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "memorySizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stockStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StockStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vcpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayRdbNodeTypes.DataScalewayRdbNodeTypesNodeTypes\"}", isOptional: true)]
        public virtual scaleway.DataScalewayRdbNodeTypes.IDataScalewayRdbNodeTypesNodeTypes? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayRdbNodeTypes.IDataScalewayRdbNodeTypesNodeTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
