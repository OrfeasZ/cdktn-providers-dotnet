using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJob
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference), fullyQualifiedName: "oci.dataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationList ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationList>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationList ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceJob.IDataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.IDataOciDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
