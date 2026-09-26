using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersDeployments
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersDeployments.DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersDeployments.DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersDeploymentsResultDeploymentsAnnotationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkersMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workersTriggeredBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkersTriggeredBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersDeployments.DataCloudflareWorkersDeploymentsResultDeploymentsAnnotations\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersDeployments.IDataCloudflareWorkersDeploymentsResultDeploymentsAnnotations? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersDeployments.IDataCloudflareWorkersDeploymentsResultDeploymentsAnnotations?>();
            set => SetInstanceProperty(value);
        }
    }
}
