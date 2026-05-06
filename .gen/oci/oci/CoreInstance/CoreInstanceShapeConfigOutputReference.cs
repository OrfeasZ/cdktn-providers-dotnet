using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiClass(nativeType: typeof(oci.CoreInstance.CoreInstanceShapeConfigOutputReference), fullyQualifiedName: "oci.coreInstance.CoreInstanceShapeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstanceShapeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstanceShapeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstanceShapeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstanceShapeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBaselineOcpuUtilization")]
        public virtual void ResetBaselineOcpuUtilization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryInGbs")]
        public virtual void ResetMemoryInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvmes")]
        public virtual void ResetNvmes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpus")]
        public virtual void ResetOcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceManagement")]
        public virtual void ResetResourceManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpus")]
        public virtual void ResetVcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "gpuDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpuDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localDiskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalDiskDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localDisks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalDisks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localDisksTotalSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalDisksTotalSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxVnicAttachments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxVnicAttachments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkingBandwidthInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkingBandwidthInGbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "processorDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baselineOcpuUtilizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaselineOcpuUtilizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvmesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NvmesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceManagementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceManagementInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaselineOcpuUtilization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Nvmes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceManagement
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vcpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstanceShapeConfig\"}", isOptional: true)]
        public virtual oci.CoreInstance.ICoreInstanceShapeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstance.ICoreInstanceShapeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
