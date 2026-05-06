using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiClass(nativeType: typeof(oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputReference), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasciencePipelineStepDetailsStepParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasciencePipelineStepDetailsStepParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasciencePipelineStepDetailsStepParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineStepDetailsStepParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput\"}}]")]
        public virtual void PutOutput(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput)}, new object[]{@value});
        }

        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputOutputReference Output
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput? OutputInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParameterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParameterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters? InternalValue
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
