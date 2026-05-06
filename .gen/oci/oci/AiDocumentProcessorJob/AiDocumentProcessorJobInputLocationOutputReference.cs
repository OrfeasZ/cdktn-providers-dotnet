using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiClass(nativeType: typeof(oci.AiDocumentProcessorJob.AiDocumentProcessorJobInputLocationOutputReference), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiDocumentProcessorJobInputLocationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiDocumentProcessorJobInputLocationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiDocumentProcessorJobInputLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentProcessorJobInputLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putObjectLocations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutObjectLocations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocationObjectLocations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocationObjectLocations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocationObjectLocations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetData")]
        public virtual void ResetData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectLocations")]
        public virtual void ResetObjectLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPageRange")]
        public virtual void ResetPageRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "objectLocations", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocationsList\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocationsList ObjectLocations
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLocationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ObjectLocationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageRangeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PageRangeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Data
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pageRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PageRange
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation\"}", isOptional: true)]
        public virtual oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation? InternalValue
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
