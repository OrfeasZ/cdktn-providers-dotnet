using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersDeployment
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentAnnotationsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentAnnotationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersDeploymentAnnotationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersDeploymentAnnotationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersDeploymentAnnotationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersDeploymentAnnotationsOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentAnnotations\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersDeployment.IDataCloudflareWorkersDeploymentAnnotations? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersDeployment.IDataCloudflareWorkersDeploymentAnnotations?>();
            set => SetInstanceProperty(value);
        }
    }
}
