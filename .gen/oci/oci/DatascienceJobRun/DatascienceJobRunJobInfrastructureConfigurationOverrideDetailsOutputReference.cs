using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJobShapeConfigDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails\"}}]")]
        public virtual void PutJobShapeConfigDetails(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockStorageSizeInGbs")]
        public virtual void ResetBlockStorageSizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobShapeConfigDetails")]
        public virtual void ResetJobShapeConfigDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeName")]
        public virtual void ResetShapeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetailsOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetailsOutputReference JobShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockStorageSizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobInfrastructureTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobInfrastructureTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobShapeConfigDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails? JobShapeConfigDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails?>();
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

        [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobInfrastructureType
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
