using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiClass(nativeType: typeof(oci.DifStack.DifStackDataflowExecutorShapeConfigOutputReference), fullyQualifiedName: "oci.difStack.DifStackDataflowExecutorShapeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DifStackDataflowExecutorShapeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DifStackDataflowExecutorShapeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DifStackDataflowExecutorShapeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackDataflowExecutorShapeConfigOutputReference(DeputyProps props): base(props)
        {
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowExecutorShapeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowExecutorShapeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
