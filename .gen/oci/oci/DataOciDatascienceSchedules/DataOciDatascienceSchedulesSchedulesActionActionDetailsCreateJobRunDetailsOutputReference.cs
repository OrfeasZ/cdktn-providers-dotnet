using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetailsList JobConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetailsList JobEnvironmentConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetailsList JobLogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceSchedules.IDataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.IDataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
