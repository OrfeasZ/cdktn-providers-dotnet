using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSagemakerHubContent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/data-sources/sagemaker_hub_content aws_sagemaker_hub_content}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsSagemakerHubContent.DataAwsSagemakerHubContent), fullyQualifiedName: "aws.dataAwsSagemakerHubContent.DataAwsSagemakerHubContent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsSagemakerHubContent.DataAwsSagemakerHubContentConfig\"}}]")]
    public class DataAwsSagemakerHubContent : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/data-sources/sagemaker_hub_content aws_sagemaker_hub_content} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSagemakerHubContent(Constructs.Construct scope, string id, aws.DataAwsSagemakerHubContent.IDataAwsSagemakerHubContentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsSagemakerHubContent.IDataAwsSagemakerHubContentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSagemakerHubContent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSagemakerHubContent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsSagemakerHubContent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsSagemakerHubContent to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsSagemakerHubContent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsSagemakerHubContent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsSagemakerHubContent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/data-sources/sagemaker_hub_content#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsSagemakerHubContent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsSagemakerHubContent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsSagemakerHubContent.DataAwsSagemakerHubContent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetHubContentVersion")]
        public virtual void ResetHubContentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsSagemakerHubContent.DataAwsSagemakerHubContent))!;

        [JsiiProperty(name: "creationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentDependency", typeJson: "{\"fqn\":\"aws.dataAwsSagemakerHubContent.DataAwsSagemakerHubContentHubContentDependencyList\"}")]
        public virtual aws.DataAwsSagemakerHubContent.DataAwsSagemakerHubContentHubContentDependencyList HubContentDependency
        {
            get => GetInstanceProperty<aws.DataAwsSagemakerHubContent.DataAwsSagemakerHubContentHubContentDependencyList>()!;
        }

        [JsiiProperty(name: "hubContentDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentDocument
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentMarkdown", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentMarkdown
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentSearchKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HubContentSearchKeywords
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hubContentStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModifiedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceMinVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceMinVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sagemakerPublicHubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SagemakerPublicHubContentArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionedHubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionedHubContentArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubContentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubContentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubContentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubContentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubContentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubContentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hubContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hubContentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hubName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
