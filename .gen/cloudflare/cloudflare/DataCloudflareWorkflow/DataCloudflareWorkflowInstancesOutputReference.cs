using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkflow
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkflow.DataCloudflareWorkflowInstancesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkflow.DataCloudflareWorkflowInstancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkflowInstancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkflowInstancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkflowInstancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkflowInstancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "complete", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Complete
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "errored", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Errored
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "paused", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Paused
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queued", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Queued
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "running", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Running
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "terminated", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Terminated
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "waiting", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Waiting
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "waitingForPause", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitingForPause
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkflow.DataCloudflareWorkflowInstances\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkflow.IDataCloudflareWorkflowInstances? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkflow.IDataCloudflareWorkflowInstances?>();
            set => SetInstanceProperty(value);
        }
    }
}
