using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiClass(nativeType: typeof(oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActionOnDdlError")]
        public virtual void ResetActionOnDdlError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActionOnDmlError")]
        public virtual void ResetActionOnDmlError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnDdlErrorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnDdlErrorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnDmlErrorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnDmlErrorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "canReplicateSchemaChangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CanReplicateSchemaChangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "actionOnDdlError", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnDdlError
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "actionOnDmlError", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnDmlError
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "canReplicateSchemaChange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CanReplicateSchemaChange
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange?>();
            set => SetInstanceProperty(value);
        }
    }
}
