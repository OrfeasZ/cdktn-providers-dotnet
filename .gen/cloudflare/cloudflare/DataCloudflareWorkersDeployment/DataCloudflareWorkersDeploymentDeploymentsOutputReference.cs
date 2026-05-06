using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersDeployment
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWorkersDeploymentDeploymentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWorkersDeploymentDeploymentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersDeploymentDeploymentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersDeploymentDeploymentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsAnnotationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "authorEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsVersionsList\"}")]
        public virtual cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsVersionsList Versions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeploymentsVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersDeployment.DataCloudflareWorkersDeploymentDeployments\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersDeployment.IDataCloudflareWorkersDeploymentDeployments? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersDeployment.IDataCloudflareWorkersDeploymentDeployments?>();
            set => SetInstanceProperty(value);
        }
    }
}
