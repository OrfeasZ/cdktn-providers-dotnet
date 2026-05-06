using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiClass(nativeType: typeof(oci.DatascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuBaseline")]
        public virtual void ResetCpuBaseline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryInGbs")]
        public virtual void ResetMemoryInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpus")]
        public virtual void ResetOcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuBaselineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuBaselineInput
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
        [JsiiProperty(name: "ocpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cpuBaseline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuBaseline
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

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails\"}", isOptional: true)]
        public virtual oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
