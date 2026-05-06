using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    [JsiiClass(nativeType: typeof(cloudflare.WorkersDeployment.WorkersDeploymentDeploymentsOutputReference), fullyQualifiedName: "cloudflare.workersDeployment.WorkersDeploymentDeploymentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class WorkersDeploymentDeploymentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public WorkersDeploymentDeploymentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected WorkersDeploymentDeploymentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkersDeploymentDeploymentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workersDeployment.WorkersDeploymentDeploymentsAnnotationsOutputReference\"}")]
        public virtual cloudflare.WorkersDeployment.WorkersDeploymentDeploymentsAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.WorkersDeployment.WorkersDeploymentDeploymentsAnnotationsOutputReference>()!;
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

        [JsiiProperty(name: "versions", typeJson: "{\"fqn\":\"cloudflare.workersDeployment.WorkersDeploymentDeploymentsVersionsList\"}")]
        public virtual cloudflare.WorkersDeployment.WorkersDeploymentDeploymentsVersionsList Versions
        {
            get => GetInstanceProperty<cloudflare.WorkersDeployment.WorkersDeploymentDeploymentsVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.workersDeployment.WorkersDeploymentDeployments\"}", isOptional: true)]
        public virtual cloudflare.WorkersDeployment.IWorkersDeploymentDeployments? InternalValue
        {
            get => GetInstanceProperty<cloudflare.WorkersDeployment.IWorkersDeploymentDeployments?>();
            set => SetInstanceProperty(value);
        }
    }
}
