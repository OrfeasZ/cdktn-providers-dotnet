using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDatalab
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDatalab.DataScalewayDatalabMainOutputReference), fullyQualifiedName: "scaleway.dataScalewayDatalab.DataScalewayDatalabMainOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataScalewayDatalabMainOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataScalewayDatalabMainOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataScalewayDatalabMainOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDatalabMainOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootVolume", typeJson: "{\"fqn\":\"scaleway.dataScalewayDatalab.DataScalewayDatalabMainRootVolumeOutputReference\"}")]
        public virtual scaleway.DataScalewayDatalab.DataScalewayDatalabMainRootVolumeOutputReference RootVolume
        {
            get => GetInstanceProperty<scaleway.DataScalewayDatalab.DataScalewayDatalabMainRootVolumeOutputReference>()!;
        }

        [JsiiProperty(name: "sparkMasterUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkMasterUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sparkUiUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkUiUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDatalab.DataScalewayDatalabMain\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDatalab.IDataScalewayDatalabMain? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDatalab.IDataScalewayDatalabMain?>();
            set => SetInstanceProperty(value);
        }
    }
}
