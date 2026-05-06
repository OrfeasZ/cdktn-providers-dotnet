using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobsJobsJobNodeConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "jobNetworkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNetworkConfigurationList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNetworkConfigurationList JobNetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "jobNodeGroupConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList JobNodeGroupConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "jobNodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobNodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumRuntimeInMinutes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startupOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartupOrder
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceJobs.IDataOciDatascienceJobsJobsJobNodeConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.IDataOciDatascienceJobsJobsJobNodeConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
