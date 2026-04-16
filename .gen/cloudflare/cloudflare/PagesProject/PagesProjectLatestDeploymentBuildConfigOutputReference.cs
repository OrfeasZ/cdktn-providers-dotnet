using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectLatestDeploymentBuildConfigOutputReference), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectLatestDeploymentBuildConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectLatestDeploymentBuildConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectLatestDeploymentBuildConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectLatestDeploymentBuildConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectLatestDeploymentBuildConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "buildCaching", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BuildCaching
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webAnalyticsTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebAnalyticsTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webAnalyticsToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebAnalyticsToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentBuildConfig\"}", isOptional: true)]
        public virtual cloudflare.PagesProject.IPagesProjectLatestDeploymentBuildConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectLatestDeploymentBuildConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
