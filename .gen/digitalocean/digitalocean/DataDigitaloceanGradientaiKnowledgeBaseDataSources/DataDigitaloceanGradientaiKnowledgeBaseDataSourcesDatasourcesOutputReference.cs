using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesFileUploadDataSourceList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesFileUploadDataSourceList FileUploadDataSource
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesFileUploadDataSourceList>()!;
        }

        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesLastIndexingJobList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesLastIndexingJobList LastIndexingJob
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesLastIndexingJobList>()!;
        }

        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesSpacesDataSourceList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesSpacesDataSourceList SpacesDataSource
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesSpacesDataSourceList>()!;
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

        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesWebCrawlerDataSourceList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesWebCrawlerDataSourceList WebCrawlerDataSource
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasourcesWebCrawlerDataSourceList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBaseDataSources.DataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasources\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.IDataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasources? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBaseDataSources.IDataDigitaloceanGradientaiKnowledgeBaseDataSourcesDatasources?>();
            set => SetInstanceProperty(value);
        }
    }
}
