using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiClass(nativeType: typeof(oci.DatasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShapeConfigDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails\"}}]")]
        public virtual void PutShapeConfigDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockStorageSizeInGbsParameterized")]
        public virtual void ResetBlockStorageSizeInGbsParameterized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfigDetails")]
        public virtual void ResetShapeConfigDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetailsOutputReference ShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockStorageSizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbsParameterizedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockStorageSizeInGbsParameterizedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails? ShapeConfigDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockStorageSizeInGbsParameterized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockStorageSizeInGbsParameterized
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
