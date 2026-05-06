using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetLibraryApplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetLibraryApplications.DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsFleetLibraryApplications.DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstSeenInClasspath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstSeenInClasspath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastDetectedDynamically", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastDetectedDynamically
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastSeenInClasspath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSeenInClasspath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManagedInstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetLibraryApplications.DataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsFleetLibraryApplications.IDataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetLibraryApplications.IDataOciJmsFleetLibraryApplicationsLibraryApplicationUsageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
