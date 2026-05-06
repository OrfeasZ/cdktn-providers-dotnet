using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationImplementation
{
    [JsiiClass(nativeType: typeof(oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingOutputReference), fullyQualifiedName: "oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceMlApplicationImplementationLoggingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceMlApplicationImplementationLoggingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceMlApplicationImplementationLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceMlApplicationImplementationLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAggregatedInstanceViewLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog\"}}]")]
        public virtual void PutAggregatedInstanceViewLog(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImplementationLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLog\"}}]")]
        public virtual void PutImplementationLog(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingImplementationLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingImplementationLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTriggerLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLog\"}}]")]
        public virtual void PutTriggerLog(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingTriggerLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingTriggerLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAggregatedInstanceViewLog")]
        public virtual void ResetAggregatedInstanceViewLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImplementationLog")]
        public virtual void ResetImplementationLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerLog")]
        public virtual void ResetTriggerLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aggregatedInstanceViewLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLogOutputReference\"}")]
        public virtual oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLogOutputReference AggregatedInstanceViewLog
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLogOutputReference>()!;
        }

        [JsiiProperty(name: "implementationLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLogOutputReference\"}")]
        public virtual oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLogOutputReference ImplementationLog
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLogOutputReference>()!;
        }

        [JsiiProperty(name: "triggerLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLogOutputReference\"}")]
        public virtual oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLogOutputReference TriggerLog
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLogOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregatedInstanceViewLogInput", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog\"}", isOptional: true)]
        public virtual oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog? AggregatedInstanceViewLogInput
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "implementationLogInput", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLog\"}", isOptional: true)]
        public virtual oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingImplementationLog? ImplementationLogInput
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingImplementationLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerLogInput", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLog\"}", isOptional: true)]
        public virtual oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingTriggerLog? TriggerLogInput
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingTriggerLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLogging\"}", isOptional: true)]
        public virtual oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLogging? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
