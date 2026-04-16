using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProjects
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "endedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultCanonicalDeploymentLatestStage\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultCanonicalDeploymentLatestStage? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultCanonicalDeploymentLatestStage?>();
            set => SetInstanceProperty(value);
        }
    }
}
