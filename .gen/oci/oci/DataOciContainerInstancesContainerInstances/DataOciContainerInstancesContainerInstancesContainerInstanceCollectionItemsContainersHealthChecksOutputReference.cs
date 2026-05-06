using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerInstancesContainerInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference), fullyQualifiedName: "oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "failureAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksHeadersList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksHeadersList Headers
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksHeadersList>()!;
        }

        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialDelayInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialDelayInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuccessThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecks\"}", isOptional: true)]
        public virtual oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecks? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecks?>();
            set => SetInstanceProperty(value);
        }
    }
}
