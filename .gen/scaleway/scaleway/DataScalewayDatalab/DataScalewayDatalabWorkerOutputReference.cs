using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDatalab
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDatalab.DataScalewayDatalabWorkerOutputReference), fullyQualifiedName: "scaleway.dataScalewayDatalab.DataScalewayDatalabWorkerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataScalewayDatalabWorkerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataScalewayDatalabWorkerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataScalewayDatalabWorkerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDatalabWorkerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootVolume", typeJson: "{\"fqn\":\"scaleway.dataScalewayDatalab.DataScalewayDatalabWorkerRootVolumeOutputReference\"}")]
        public virtual scaleway.DataScalewayDatalab.DataScalewayDatalabWorkerRootVolumeOutputReference RootVolume
        {
            get => GetInstanceProperty<scaleway.DataScalewayDatalab.DataScalewayDatalabWorkerRootVolumeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDatalab.DataScalewayDatalabWorker\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDatalab.IDataScalewayDatalabWorker? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDatalab.IDataScalewayDatalabWorker?>();
            set => SetInstanceProperty(value);
        }
    }
}
