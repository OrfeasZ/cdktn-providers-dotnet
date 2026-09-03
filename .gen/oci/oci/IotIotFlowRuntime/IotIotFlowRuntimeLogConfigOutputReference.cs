using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    [JsiiClass(nativeType: typeof(oci.IotIotFlowRuntime.IotIotFlowRuntimeLogConfigOutputReference), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotIotFlowRuntimeLogConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotIotFlowRuntimeLogConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotIotFlowRuntimeLogConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotFlowRuntimeLogConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLogId")]
        public virtual void ResetLogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig\"}", isOptional: true)]
        public virtual oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig? InternalValue
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
