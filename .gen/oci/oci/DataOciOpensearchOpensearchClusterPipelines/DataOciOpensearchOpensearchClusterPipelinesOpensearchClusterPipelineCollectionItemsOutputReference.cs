using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpensearchOpensearchClusterPipelines
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataPrepperConfigurationBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataPrepperConfigurationBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsgId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OpcDryRun
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "opensearchPipelineFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpensearchPipelineFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opensearchPipelinePrivateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpensearchPipelinePrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pipelineConfigurationBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineConfigurationBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pipelineMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpoints", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsReverseConnectionEndpointsList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsReverseConnectionEndpointsList ReverseConnectionEndpoints
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItemsReverseConnectionEndpointsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "vcnCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusterPipelines.DataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOpensearchOpensearchClusterPipelines.IDataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusterPipelines.IDataOciOpensearchOpensearchClusterPipelinesOpensearchClusterPipelineCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
