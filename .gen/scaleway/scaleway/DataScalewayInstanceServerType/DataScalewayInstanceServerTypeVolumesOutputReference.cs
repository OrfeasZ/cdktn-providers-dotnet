using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayInstanceServerType
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumesOutputReference), fullyQualifiedName: "scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayInstanceServerTypeVolumesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayInstanceServerTypeVolumesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayInstanceServerTypeVolumesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceServerTypeVolumesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "blockStorage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BlockStorage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxSizePerLocalVolume", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSizePerLocalVolume
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSizeTotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSizeTotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSizePerLocalVolume", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSizePerLocalVolume
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSizeTotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSizeTotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scratchStorageMaxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScratchStorageMaxSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumes\"}", isOptional: true)]
        public virtual scaleway.DataScalewayInstanceServerType.IDataScalewayInstanceServerTypeVolumes? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServerType.IDataScalewayInstanceServerTypeVolumes?>();
            set => SetInstanceProperty(value);
        }
    }
}
