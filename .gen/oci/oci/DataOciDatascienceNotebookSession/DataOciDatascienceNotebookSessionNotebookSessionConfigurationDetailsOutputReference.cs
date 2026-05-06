using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceNotebookSession
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "notebookSessionShapeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsList\"}")]
        public virtual oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsList NotebookSessionShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceNotebookSession.IDataOciDatascienceNotebookSessionNotebookSessionConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.IDataOciDatascienceNotebookSessionNotebookSessionConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
