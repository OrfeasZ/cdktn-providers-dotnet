using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference), fullyQualifiedName: "oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationInstallationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationInstallationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "excludePackagePrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludePackagePrefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "includePackagePrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludePackagePrefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceJdkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceJdkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetJdkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetJdkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets\"}", isOptional: true)]
        public virtual oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets?>();
            set => SetInstanceProperty(value);
        }
    }
}
