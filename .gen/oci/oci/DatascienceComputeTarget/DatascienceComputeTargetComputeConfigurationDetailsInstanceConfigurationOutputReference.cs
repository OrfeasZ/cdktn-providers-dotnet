using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiClass(nativeType: typeof(oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceShapeDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}}]")]
        public virtual void PutInstanceShapeDetails(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBootVolumeSizeInGbs")]
        public virtual void ResetBootVolumeSizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceShapeDetails")]
        public virtual void ResetInstanceShapeDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceShapeDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetailsOutputReference\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetailsOutputReference InstanceShapeDetails
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeSizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BootVolumeSizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails? InstanceShapeDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BootVolumeSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
