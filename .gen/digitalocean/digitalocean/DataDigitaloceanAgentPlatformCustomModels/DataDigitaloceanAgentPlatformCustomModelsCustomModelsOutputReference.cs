using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformCustomModels
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformCustomModelsCustomModelsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDeployments", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsActiveDeploymentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsActiveDeploymentsList ActiveDeployments
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsActiveDeploymentsList>()!;
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contextLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContextLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "costEstimatePerMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostEstimatePerMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FileCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InputModalities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string License
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutputModalities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Parameters
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsSourceRefList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsSourceRefList SourceRef
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModelsSourceRefList>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TeamId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSizeBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSizeBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModels.DataDigitaloceanAgentPlatformCustomModelsCustomModels\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformCustomModels.IDataDigitaloceanAgentPlatformCustomModelsCustomModels? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformCustomModels.IDataDigitaloceanAgentPlatformCustomModelsCustomModels?>();
            set => SetInstanceProperty(value);
        }
    }
}
