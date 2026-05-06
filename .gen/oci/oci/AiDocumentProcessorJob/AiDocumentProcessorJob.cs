using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job oci_ai_document_processor_job}.</summary>
    [JsiiClass(nativeType: typeof(oci.AiDocumentProcessorJob.AiDocumentProcessorJob), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobConfig\"}}]")]
    public class AiDocumentProcessorJob : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job oci_ai_document_processor_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AiDocumentProcessorJob(Constructs.Construct scope, string id, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentProcessorJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentProcessorJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AiDocumentProcessorJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AiDocumentProcessorJob to import.</param>
        /// <param name="importFromId">The id of the existing AiDocumentProcessorJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AiDocumentProcessorJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AiDocumentProcessorJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AiDocumentProcessorJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AiDocumentProcessorJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AiDocumentProcessorJob.AiDocumentProcessorJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInputLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation\"}}]")]
        public virtual void PutInputLocation(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobOutputLocation\"}}]")]
        public virtual void PutOutputLocation(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobOutputLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobOutputLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessorConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig\"}}]")]
        public virtual void PutProcessorConfig(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.AiDocumentProcessorJob.AiDocumentProcessorJob))!;

        [JsiiProperty(name: "inputLocation", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationOutputReference\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobInputLocationOutputReference InputLocation
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobInputLocationOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobOutputLocationOutputReference\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobOutputLocationOutputReference OutputLocation
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobOutputLocationOutputReference>()!;
        }

        [JsiiProperty(name: "percentComplete", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentComplete
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "processorConfig", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigOutputReference\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigOutputReference ProcessorConfig
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobTimeoutsOutputReference\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLocationInput", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation\"}", isOptional: true)]
        public virtual oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation? InputLocationInput
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocationInput", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobOutputLocation\"}", isOptional: true)]
        public virtual oci.AiDocumentProcessorJob.IAiDocumentProcessorJobOutputLocation? OutputLocationInput
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.IAiDocumentProcessorJobOutputLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processorConfigInput", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig\"}", isOptional: true)]
        public virtual oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig? ProcessorConfigInput
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
