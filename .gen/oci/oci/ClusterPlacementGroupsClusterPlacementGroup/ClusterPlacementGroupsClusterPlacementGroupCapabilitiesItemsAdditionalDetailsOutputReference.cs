using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    [JsiiClass(nativeType: typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClusterPlacementGroupCount")]
        public virtual void ResetClusterPlacementGroupCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryInGbs")]
        public virtual void ResetMemoryInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvmes")]
        public virtual void ResetNvmes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpus")]
        public virtual void ResetOcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClusterPlacementGroupCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvmesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NvmesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterPlacementGroupCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClusterPlacementGroupCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Nvmes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails\"}", isOptional: true)]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilitiesItemsAdditionalDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
