using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHubContentReference
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/sagemaker_hub_content_reference aws_sagemaker_hub_content_reference}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerHubContentReference.SagemakerHubContentReference), fullyQualifiedName: "aws.sagemakerHubContentReference.SagemakerHubContentReference", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceConfig\"}}]")]
    public class SagemakerHubContentReference : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/sagemaker_hub_content_reference aws_sagemaker_hub_content_reference} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerHubContentReference(Constructs.Construct scope, string id, aws.SagemakerHubContentReference.ISagemakerHubContentReferenceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerHubContentReference.ISagemakerHubContentReferenceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerHubContentReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerHubContentReference(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SagemakerHubContentReference resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerHubContentReference to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerHubContentReference that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerHubContentReference to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerHubContentReference to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/sagemaker_hub_content_reference#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerHubContentReference that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerHubContentReference to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.SagemakerHubContentReference.SagemakerHubContentReference), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMinVersion")]
        public virtual void ResetMinVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerHubContentReference.SagemakerHubContentReference))!;

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

        [JsiiProperty(name: "hubContentStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hubContentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceTimeoutsOutputReference\"}")]
        public virtual aws.SagemakerHubContentReference.SagemakerHubContentReferenceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.SagemakerHubContentReference.SagemakerHubContentReferenceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubContentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubContentNameInput
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
        [JsiiProperty(name: "minVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPublicHubContentArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SagemakerPublicHubContentArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentName
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

        [JsiiProperty(name: "minVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinVersion
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

        [JsiiProperty(name: "sagemakerPublicHubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SagemakerPublicHubContentArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
