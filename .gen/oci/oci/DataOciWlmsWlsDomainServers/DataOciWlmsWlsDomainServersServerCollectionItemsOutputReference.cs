using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWlmsWlsDomainServers
{
    [JsiiClass(nativeType: typeof(oci.DataOciWlmsWlsDomainServers.DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciWlmsWlsDomainServers.DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWlmsWlsDomainServersServerCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAdmin", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAdmin
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jdkPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JdkPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jdkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JdkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestPatchesStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestPatchesStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "middlewarePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddlewarePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "middlewareType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddlewareType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchReadinessStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchReadinessStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restartOrder", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RestartOrder
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weblogicVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeblogicVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wlsDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WlsDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wlsDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WlsDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wlsDomainPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WlsDomainPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWlmsWlsDomainServers.DataOciWlmsWlsDomainServersServerCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciWlmsWlsDomainServers.IDataOciWlmsWlsDomainServersServerCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWlmsWlsDomainServers.IDataOciWlmsWlsDomainServersServerCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
