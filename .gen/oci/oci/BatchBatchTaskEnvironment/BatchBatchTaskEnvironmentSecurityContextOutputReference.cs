using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskEnvironment
{
    [JsiiClass(nativeType: typeof(oci.BatchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContextOutputReference), fullyQualifiedName: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchBatchTaskEnvironmentSecurityContextOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchBatchTaskEnvironmentSecurityContextOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchBatchTaskEnvironmentSecurityContextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchBatchTaskEnvironmentSecurityContextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFsGroup")]
        public virtual void ResetFsGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunAsGroup")]
        public virtual void ResetRunAsGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunAsUser")]
        public virtual void ResetRunAsUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsGroupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsGroupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runAsGroupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RunAsGroupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runAsUserInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RunAsUserInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsGroup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunAsGroup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunAsUser
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContext\"}", isOptional: true)]
        public virtual oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentSecurityContext? InternalValue
        {
            get => GetInstanceProperty<oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentSecurityContext?>();
            set => SetInstanceProperty(value);
        }
    }
}
