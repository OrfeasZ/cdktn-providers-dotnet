using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference), fullyQualifiedName: "oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSitesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceInstall", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForceInstall
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "headlessMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HeadlessMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "installationPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstallationPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites\"}", isOptional: true)]
        public virtual oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestInstallationSites?>();
            set => SetInstanceProperty(value);
        }
    }
}
