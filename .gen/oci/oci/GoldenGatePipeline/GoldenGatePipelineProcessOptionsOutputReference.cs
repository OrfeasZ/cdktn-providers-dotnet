using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiClass(nativeType: typeof(oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsOutputReference), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGatePipelineProcessOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGatePipelineProcessOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGatePipelineProcessOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGatePipelineProcessOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInitialDataLoad", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}}]")]
        public virtual void PutInitialDataLoad(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicateSchemaChange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}}]")]
        public virtual void PutReplicateSchemaChange(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStartUsingDefaultMapping")]
        public virtual void ResetStartUsingDefaultMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "initialDataLoad", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference InitialDataLoad
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference>()!;
        }

        [JsiiProperty(name: "replicateSchemaChange", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference\"}")]
        public virtual oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference ReplicateSchemaChange
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialDataLoadInput", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad? InitialDataLoadInput
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicateSchemaChangeInput", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange? ReplicateSchemaChangeInput
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shouldRestartOnFailureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShouldRestartOnFailureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startUsingDefaultMappingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartUsingDefaultMappingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "shouldRestartOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShouldRestartOnFailure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startUsingDefaultMapping", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartUsingDefaultMapping
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptions\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
