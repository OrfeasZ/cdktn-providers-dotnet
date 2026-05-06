using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceContainers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference), fullyQualifiedName: "oci.dataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStructOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalConfigurations", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalConfigurations
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "cmd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cmd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serverPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ServerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "useCaseConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListUseCaseConfigurationList\"}")]
        public virtual oci.DataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListUseCaseConfigurationList UseCaseConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListUseCaseConfigurationList>()!;
        }

        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceContainers.DataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStruct\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceContainers.IDataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStruct? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceContainers.IDataOciDatascienceContainersContainersWorkloadConfigurationDetailsListStruct?>();
            set => SetInstanceProperty(value);
        }
    }
}
